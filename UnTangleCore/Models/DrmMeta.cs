using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the meta block in the data section of the preset file.
    /// </summary>
    [DataContract]
    public class DrmMeta
    {
        [DataMember]
        [JsonProperty(PropertyName = "original")]
        public int Original { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "pbn")]
        public int Pbn { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "premium")]
        public int Premium { get; set; }
    };
}
