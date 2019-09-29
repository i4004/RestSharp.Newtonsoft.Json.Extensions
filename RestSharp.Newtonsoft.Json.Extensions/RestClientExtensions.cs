namespace RestSharp.Newtonsoft.Json.Extensions
{
	/// <summary>
	/// Provides RestClient Newtonsoft.Json extensions
	/// </summary>
	public static class RestClientExtensions
	{
		/// <summary>
		/// Uses the Newtonsoft.Json deserializer as deserializer for IRestClient.
		/// </summary>
		/// <param name="client">The client.</param>
		public static void UseNewtonsoftJsonDeserializer(this IRestClient client)
		{
			var deserializer = NewtonsoftJsonSerializer.Default;

			client.AddHandler("application/json", () => deserializer);
			client.AddHandler("text/json", () => deserializer);
			client.AddHandler("text/x-json", () => deserializer);
			client.AddHandler("text/javascript", () => deserializer);
			client.AddHandler("*+json", () => deserializer);
		}
	}
}