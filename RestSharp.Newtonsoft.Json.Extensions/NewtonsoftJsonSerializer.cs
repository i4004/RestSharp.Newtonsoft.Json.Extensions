using System;
using System.IO;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace RestSharp.Newtonsoft.Json.Extensions
{
	/// <summary>
	/// Provides Newtonsoft.Json serializer implementation for RestSharp
	/// </summary>
	/// <seealso cref="ISerializer" />
	/// <seealso cref="IDeserializer" />
	public class NewtonsoftJsonSerializer : ISerializer, IDeserializer
	{
		private static NewtonsoftJsonSerializer _default;

		private readonly global::Newtonsoft.Json.JsonSerializer _serializer;

		/// <summary>
		/// Initializes a new instance of the <see cref="NewtonsoftJsonSerializer"/> class.
		/// </summary>
		/// <param name="serializer">The serializer.</param>
		public NewtonsoftJsonSerializer(global::Newtonsoft.Json.JsonSerializer serializer)
		{
			_serializer = serializer;
		}

		/// <summary>
		/// Gets or sets the default serializer.
		/// </summary>
		/// <value>
		/// The default serializer.
		/// </value>
		/// <exception cref="System.NullReferenceException">value</exception>
		public static NewtonsoftJsonSerializer Default
		{
			get
			{
				if (_default != null)
					return _default;

				_default = new NewtonsoftJsonSerializer(new global::Newtonsoft.Json.JsonSerializer
				{
					NullValueHandling = NullValueHandling.Ignore
				});

				return _default;
			}
			set
			{
				if (value == null)
					throw new NullReferenceException(nameof(value));

				_default = value;
			}
		}

		/// <summary>
		/// Gets or sets the type of the content.
		/// </summary>
		/// <value>
		/// The type of the content.
		/// </value>
		public string ContentType { get; set; } = "application/json";

		/// <summary>
		/// Gets or sets the date format.
		/// </summary>
		/// <value>
		/// The date format.
		/// </value>
		public string DateFormat { get; set; }

		/// <summary>
		/// Gets or sets the namespace.
		/// </summary>
		/// <value>
		/// The namespace.
		/// </value>
		public string Namespace { get; set; }

		/// <summary>
		/// Gets or sets the root element.
		/// </summary>
		/// <value>
		/// The root element.
		/// </value>
		public string RootElement { get; set; }

		/// <summary>
		/// Serializes the specified object.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns></returns>
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

		/// <summary>
		/// Deserializes the specified response data.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="response">The response.</param>
		/// <returns></returns>
		public virtual T Deserialize<T>(IRestResponse response)
		{
			using (var stringReader = new StringReader(response.Content))
			using (var jsonTextReader = new JsonTextReader(stringReader))
				return _serializer.Deserialize<T>(jsonTextReader);
		}
	}
}