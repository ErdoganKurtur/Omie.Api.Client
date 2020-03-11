
![Nuget](https://img.shields.io/nuget/v/Omie.Api.Client.svg)

> Read this in other languages: [English](README.md)

# Omie.Api.Client
 Biblioteca .net para consumo da api Omie


# Iniciando com o pacote

```
PM> Install-Package Omie.Api.Client
```

## Criando o cliente da api

```c#
var options = new OmieApiClientOptions { Token = "seu-token-omie", ApplicationId="seu-id-de-aplicação-no-omie"};
var client = new OmieClient(options);
```

### Buscando clientes

```c#
...
var customers = await client.Customers.GetManyAsync(limit:50, currentPage:1);
```
