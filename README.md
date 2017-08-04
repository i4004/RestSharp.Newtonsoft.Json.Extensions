RestSharp.Newtonsoft.Json.Extensions
===

`RestSharp.Newtonsoft.Json.Extensions` - is a RestSharp extensions to use Newtonsoft.Json for serialization/deserialization .

## Package status

| Latest version | [![Nuget version](http://img.shields.io/badge/nuget-v1.0.1-blue.png)](https://www.nuget.org/packages/RestSharp.Newtonsoft.Json.Extensions/) |
| :------ | :------: |
| **Dependencies** | [![NuGet Status](http://nugetstatus.com/RestSharp.Newtonsoft.Json.Extensions.png)](http://nugetstatus.com/packages/RestSharp.Newtonsoft.Json.Extensions) |

## Build status

| Platform | Status of last build |
| :------ | :------: |
| **.NET (4.5.2)** | [![AppVeyor build status](https://ci.appveyor.com/api/projects/status/tw195dxk1m917pc3?svg=true)](https://ci.appveyor.com/project/i4004/restsharp-newtonsoft-json-extensions) |
| **Mono (Latest)** | [![Travis build status](https://travis-ci.org/i4004/RestSharp.Newtonsoft.Json.Extensions.png?branch=master)](https://travis-ci.org/i4004/RestSharp.Newtonsoft.Json.Extensions) |

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

