using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the preset file.
    /// </summary>
    [DataContract]
    public class PresetFile
    {
        [DataMember]
        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "meta")]
        public DrmMeta Meta { get; set; }
    };
}
