namespace RestSharp.Newtonsoft.Json.Extensions
{
	public static class RestClientExtensions
	{
		public static void UseNewtonsoftJsonSerializer(this IRestClient client)
		{
			var deserializer = NewtonsoftJsonSerializer.Default;

			client.AddHandler("application/json", deserializer);
			client.AddHandler("text/json", deserializer);
			client.AddHandler("text/x-json", deserializer);
			client.AddHandler("text/javascript", deserializer);
			client.AddHandler("*+json", deserializer);
		}
	}
}