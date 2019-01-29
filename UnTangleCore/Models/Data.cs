using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class Data
    {
        [DataMember]
        [JsonProperty(PropertyName = "device")]
        public Enums.Device Device { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "device_version")]
        public string DeviceVersion { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "tone")]
        public Tone Tone { get; set; }
    };
}
