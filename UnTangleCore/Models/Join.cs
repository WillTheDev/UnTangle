using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the join section.
    /// </summary>
    [DataContract]
    public class Join
    {
        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "B Pan")]
        public float B_Pan { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "B Level")]
        public float B_Level { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "A Level")]
        public float A_Level { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "A Pan")]
        public float A_Pan { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@position")]
        public int Position { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@enabled")]
        public bool Enabled { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "B Polarity")]
        public bool B_Polarity { get; set; }
    };
}
