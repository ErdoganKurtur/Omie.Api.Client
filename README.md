
![Nuget](https://img.shields.io/nuget/v/Omie.Api.Client.svg)

> Veja essa documentação em: [Português](README.pt-BR.md)

# Omie.Api.Client
 Omie api .net client library


# Getting started

```
PM> Install-Package Omie.Api.Client
```

## Building api client

```c#
var options = new OmieApiClientOptions { Token = "your-omie-token", ApplicationId = "your-omie-application-id" };
var client = new OmieClient(options);
```

### Getting Customers

```c#
...
var customers = await client.Customers.GetManyAsync(limit:50, currentPage:1);
```