using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the tone section of the preset file.
    /// </summary>
    [DataContract]
    public class Tone
    {
        [DataMember]
        [JsonProperty(PropertyName = "global")]
        public Global Global { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot0")]
        public SnapshotBase Snapshot0 { get; set; }

        [DataMember]
        [JsonProperty (PropertyName = "snapshot1")]
        public SnapshotBase Snapshot1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot2")]
        public SnapshotBase Snapshot2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot3")]
        public SnapshotBase Snapshot3 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot4")]
        public SnapshotBase Snapshot4 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot5")]
        public SnapshotBase Snapshot5 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot6")]
        public SnapshotBase Snapshot6 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "snapshot7")]
        public SnapshotBase Snapshot7 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "dsp0")]
        public Dsp Dsp0 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "dsp1")]
        public Dsp Dsp1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "footswitch")]
        public Footswitch Footswitch { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "irUuidTable")]
        public IrUuidTable IrUuidTable { get; set; }

    };
}
