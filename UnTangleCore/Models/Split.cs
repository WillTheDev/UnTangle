using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the split section.
    /// </summary>
    [DataContract]
    public class Split
    {
        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        public float BalanceA { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@enabled")]
        public bool Enabled { get; set; }

        [DataMember]
        public bool Bypass { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@position")]
        public int Position { get; set; }

        [DataMember]
        public float BalanceB { get; set; }
    };
}
