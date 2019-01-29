using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class SnapshotBase
    {
        [DataMember]
        [JsonProperty (PropertyName = "@name")]
        public string Name { get; set; }

        [DataMember]
        [JsonProperty (PropertyName = "@tempo")]
        public double Tempo { get; set; }

        [DataMember]
        [JsonProperty (PropertyName = "@valid")]
        public bool Valid { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@pedalstate")]
        public int Pedalstate { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@ledcolor")]
        public int LedColor { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "blocks")]
        public SnapshotBlockState BlockState { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "controllers")]
        public SnapshotController Controllers { get; set; }
    };
}
