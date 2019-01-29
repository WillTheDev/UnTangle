using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the footswitch block data.
    /// </summary>
    [DataContract]
    public class FootswitchBlock
    {
        [DataMember]
        [JsonProperty(PropertyName = "@fs_ledcolor")]
        public int LedColor { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@fs_label")]
		public string Label { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@fs_enabled")]
		public bool	Enabled { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@fs_momentary")]
		public bool	Momentary { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@fs_index")]
		public int Index { get; set; }
    };
}
