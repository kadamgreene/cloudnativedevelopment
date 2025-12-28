# Cloud Native Development
## The Advent of Cloud
In March of 2006, Amazon Web Services officially launched Amazon Simple Storage Service.  This marked the beginning of the era of Cloud Computing and changed how we hosted applications, web and otherwise.

In the years that followed, as AWS and companies like Azure and GCP (both started in 2008) brought more and more services online, companies began moving their applications to "the cloud".  this meant that companies no longer had to worry about if they had enough on-premise capacity to handle the volume or scope of their applications.  They could stop thinking in terms of if they had enough computers, bandwidth, or storage for the demand for their application, because they could simply request more resources from "the Cloud".

It was also around this same time (mid-2000s) that "internet scale" applications like Facebook and YouTube became popular.  These applications created new challenges that previous companies didn't have to worry about, and that the cloud model was designed to handle: **How do you "infinitely" scale to meet demand**.

Most companies will never have to deal with the scale that companies like WhatsApp, Facebook, YouTube, and Tiktok have to, but there are lessons we can learn from them.

So let's take a look at the methodologies, tools, and frameworks that were either born from internet scale applications or found their niche with internet scale.

## Rethinking HOW we build
I think that cloud computing arose out of several key ideas that were around in the early 2000s, that came together to (re)define HOW we build software.  They are:

### Agile Software Development
In 2001, The [Agile Alliance](https://agilealliance.org/) published the *[Manifesto for Agile Software Development](https://agilealliance.org/agile101/the-agile-manifesto/)*, which focuses on:
- Individuals and interactions over processes and tools
- Working software over comprehensive documentation
- Custom collaboration over contract negotiation
- Responding to change over follow a plan

There were many different software development methodologies from which Agile arose (such as Extreme Programming and Scrum).  But all of these methodologies were in response to the Waterfall approach to software development, where an application was spec'd out and fully written before it was delivered.

This approach doesn't work in the age of the Internet and Cloud, where applications are built one feature at a time, based on the demands of the users of the application.  Teams cannot afford to wait until the entire application is built before they release it, things move to fast.

So *Agile Software Development* came about, with its focus on 2 week "sprints" in which deliverables are defined, built, and delivered to production.  Each successive sprint builds on top of the previous sprints output.  This allows the developers to respond to changes in the market, requirements, and user demand quickly.

### Conway's Law
In 1967, shortly before the internet (which debuted in 1969), Melvin Conway came up with what is now known as Conway's Law, which states:
```
Any organization that designs a system (defined broadly) will produce a design whose structure is a copy of the organization's communication structure.
```
Which basically means that how different departments within a company communicate with each other, is exactly how the different parts of their "system", which in our case is software, will communicate with each other.

In terms of talking about software development and cloud technologies, it's **Inverse Conway's Maneuver** that we want to talk about.  Inverse Conway's Maneuver is when a company restructures itself to align it business processes so that it produces the architecture that is desired in its software and decreases the cross-team / department communication, so that the development of the key parts of the system can happen quickly.

For more details on Conway's Law, see [this article](https://martinfowler.com/bliki/ConwaysLaw.html) by Martin Fowler.

### Domain Driven Design
In 2003, Eric Evans published the book *[Domain Driven Design: Tackling Complexity in the Heart of Software](https://amzn.to/4sffHEX)*.  In this book, Evans emphasized 2 key concepts: *Bounded Context* and *Ubiquitous Language*, as well as *Strategic Design* (focusing on high-level architecture and domain modeling) and *Tactical Design* (patterns and practices for implementation of the strategic design).

A *Bounded Context* is a key area within the Problem Domain, where a particular model or language is consistently used.  It draws very clear lines about what is and is not part of that model.  Within each bounded context, a *ubiquitous langauge* is established. This "language" is a set of terms, that all who are involved in that area of business function, consistently use to describe and explain that business function.  Example: underwriters at an insurance company talk about a "policy", but the customer service department at the same company can also talk about a "policy" but they are not the same thing.  That is because Underwriting and Customer Service are two distinct *Bounded Contexts*.

### Microservices
So now that we have small, agile teams, who work within a given bounded context, using a ubiquitous language, doing development in 2 week sprints, we can talk about the the next piece to this puzzle: Microservices.

The Microservice paradigm states that software is built from a bunch of small, independent services that communicate with each other over a network.  Each service is loosely coupled and fine-grained, allowing for easier scaling and deployment.

Basically, if we think in terms of Domain Driven Development, a microservice is a web application responsible for a single Bounded Context.

This allows the team who owns the microservice (as usually only a single team actually does work on a given microservice) to indepdently develop and deploy the application.

### Continous Integration/Continuous Deployment
Something that lends itself easily to the concept of microservices is the idea of Continous Integration/Continous Deployment, or CI/CD for short.

Explain.

### End Result
Every key/core/major part of the software is created by teams responsible for / own that part of the system.


- DDD
- Conway's Law
- CI/CD

- Methodologies
- Tools
- Frameworks