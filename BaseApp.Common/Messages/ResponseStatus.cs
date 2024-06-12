﻿using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;


namespace BaseApp.Common.Messages
{
    [Serializable]
    [DataContract(Name = "Response")]
    public class ResponseStatus<T>
    {
            /// <summary>
            /// Get/Set property for accessing Status Code
            /// </summary>
            [JsonProperty("StatusCode")]
            [DataMember(Name = "StatusCode")]
            public HttpStatusCode StatusCode { get; set; }

            [JsonProperty("Id")]
            [DataMember(Name = "Id")]
            public int Id { get; set; }

            /// <summary>
            /// Get/Set property for accessing Status Message
            /// </summary>
            [JsonProperty("Message")]
            [DataMember(Name = "Message")]
            public string? Messages { get; set; }

            [JsonProperty("Data")]
            [DataMember(Name = "Data")]
            public object? Data { get; set; }
    }
}
