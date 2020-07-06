# Stardog .NET Example
The Stardog .NET example show how you can use .NET code to connect to a Stardog server, manage Stardog databases and query them with TrinityRDF

## Index
- [About project](#about-project)
- [Prerequisites to run](#prerequisites-to-run)
- [Running the example](#running-the-example)

## About project
This example project demonstrates how to connect to a Stardog server using [TrinityRDF](https://trinity-rdf.net/) and execute queries using SPARQL and LINQ.

TrinityRDF provides an object mapper layer similar to Entity Framework for RDF data. The ontologies the sample uses can be found in the solution's `Ontologies/` folder. Trinity RDF discovers the ontologies in the solution's `ontologies.config` file. TrinityRDF uses the ontologies to generate mapping code - `Ontologies/Ontologies.g.cs`. A developer uses this generated code to create object models (see the files under the solution's `ObjectModels/` folder) with annotations that connect the C# object to the RDF data. These object models then allow .NET developers to create powerful applications without the need to learn SPARQL!

## Prerequisites to run

* C# development environment (e.g., Visual Studio Community, Visual Studio for Mac, Visual Studio Code, .NET Core SDK, JetBrains Rider, etc.)
* Stardog with a database named "Test" populated the data from `./examples/dotnet/TrinityConsoleSample/Ontologies/schema.ttl` in a namespace called `http://www.semanticweb.org/administrador/ontologies/2015/5/untitled-ontology-4#`

## Running the example

In Visual Studio, select the example as the Startup Project. 
Build the project and run the resulting program. The program will connect to Stardog and run several queries and print the results to STDOUT.