var builder = DistributedApplication.CreateBuilder(args);

var storage = builder.AddAzureStorage("storage").RunAsEmulator(azurite =>
{
    azurite.WithLifetime(ContainerLifetime.Persistent);
});

var clusteringTable = storage.AddTables("clustering");
var grainStorage = storage.AddBlobs("grainstorage");

var orleans = builder.AddOrleans("default")
    .WithClustering(clusteringTable)
    .WithGrainStorage("Default", grainStorage);

var apiService = builder.AddProject<Projects.CloudNativeDevelopment_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(orleans)
    .WaitFor(grainStorage)
    .WaitFor(clusteringTable);

builder.AddProject<Projects.CloudNativeDevelopment_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WithReference(orleans.AsClient())
    .WaitFor(apiService);

builder.Build().Run();
