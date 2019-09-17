RestSharp.Newtonsoft.Json.Extensions
===

`RestSharp.Newtonsoft.Json.Extensions` - is an extensions for RestSharp to use Newtonsoft.Json for serialization/deserialization.

## Package status

| Latest version | [![Nuget version](http://img.shields.io/badge/nuget-v1.0.3-blue.png)](https://www.nuget.org/packages/RestSharp.Newtonsoft.Json.Extensions/) |
| :------ | :------: |
| **Dependencies** | [![Libraries.io dependency status for latest release](https://img.shields.io/librariesio/release/nuget/RestSharp.Newtonsoft.Json.Extensions.svg)](https://libraries.io/nuget/RestSharp.Newtonsoft.Json.Extensions) |

## Build status

| Branch | **.NET 4.5.2, Standard 2.0** |
| :------ | :------: |
| **master** | [![AppVeyor build status](https://ci.appveyor.com/api/projects/status/tw195dxk1m917pc3?svg=true)](https://ci.appveyor.com/project/i4004/restsharp-newtonsoft-json-extensions) |


## Usage

### Registration for serialization

```csharp
IRestRequest request = /* ... */;
request.UseNewtonsoftJsonSerializer();
```

### Registration for deserialization

```csharp
IRestClient сlient = /* ... */;
client.UseNewtonsoftJsonDeserializer();
```

