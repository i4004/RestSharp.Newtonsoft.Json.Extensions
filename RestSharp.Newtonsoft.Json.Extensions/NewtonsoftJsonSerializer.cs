using System.IO;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace RestSharp.Newtonsoft.Json.Extensions
{
	public class NewtonsoftJsonSerializer : ISerializer, IDeserializer
	{
		private readonly global::Newtonsoft.Json.JsonSerializer _serializer;

		public NewtonsoftJsonSerializer(global::Newtonsoft.Json.JsonSerializer serializer)
		{
			_serializer = serializer;
		}

		public static NewtonsoftJsonSerializer Default => new NewtonsoftJsonSerializer(new global::Newtonsoft.Json.JsonSerializer
		{
			NullValueHandling = NullValueHandling.Ignore
		});

		public string ContentType { get; set; } = "application/json";

		public string DateFormat { get; set; }

		public string Namespace { get; set; }

		public string RootElement { get; set; }

		public virtual string Serialize(object obj)
		{
			using (var stringWriter = new StringWriter())
			{
				using (var jsonTextWriter = new JsonTextWriter(stringWriter))
				{
					_serializer.Serialize(jsonTextWriter, obj);

					return stringWriter.ToString();
				}
			}
		}

		public virtual T Deserialize<T>(IRestResponse response)
		{
			using (var stringReader = new StringReader(response.Content))
			using (var jsonTextReader = new JsonTextReader(stringReader))
				return _serializer.Deserialize<T>(jsonTextReader);
		}
	}
}