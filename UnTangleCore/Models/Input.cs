using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the input section.
    /// </summary>
    [DataContract]
    public class Input
    {
        [DataMember]
        [JsonProperty(PropertyName = "@input")]
        public int InputNumber { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        public bool NoiseGate { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float Threshold { get; set; }
    };
}
