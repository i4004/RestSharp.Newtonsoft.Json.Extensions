namespace RestSharp.Newtonsoft.Json.Extensions
{
	/// <summary>
	/// Provides RestRequest Newtonsoft.Json extensions
	/// </summary>
	public static class RestRequestExtensions
	{
		/// <summary>
		/// Uses the Newtonsoft.Json serializer as serializer for IRestRequest.
		/// </summary>
		/// <param name="request">The request.</param>
		public static void UseNewtonsoftJsonSerializer(this IRestRequest request)
		{
			request.JsonSerializer = NewtonsoftJsonSerializer.Default;
		}
	}
}