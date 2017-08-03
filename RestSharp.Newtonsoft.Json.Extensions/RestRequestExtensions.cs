namespace RestSharp.Newtonsoft.Json.Extensions
{
	public static class RestRequestExtensions
	{
		public static void UseNewtonsoftJsonSerializer(this IRestRequest request)
		{
			request.JsonSerializer = NewtonsoftJsonSerializer.Default;
		}
	}
}