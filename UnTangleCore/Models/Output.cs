using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the output section.
    /// </summary>
    [DataContract]
    public class Output
    {
        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@output")]
        public int OutputNumber { get; set; }

        [DataMember]
        public float Pan { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
