using Orleans;

namespace CloudNativeDevelopment.Grains
{
    public interface ICounterGrain : IGrainWithStringKey
    {
        Task<int> GetCountAsync();
        Task<int> IncrementAsync();
    }
}
