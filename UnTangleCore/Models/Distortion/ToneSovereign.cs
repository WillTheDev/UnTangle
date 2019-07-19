using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Tone Sovereign distortion model.
    /// </summary>
    [DataContract]
    public class ToneSovereign : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ToneSovereign()
        {
            DisplayName = ConstDistortion.DISP_TONE_SOVEREIGN;
        }

        [DataMember]
        [JsonProperty(PropertyName = "Clipping 1")]
        public int Clipping1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Clipping 2")]
        public int Clipping2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Gain 1")]
        public float Gain1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Gain 2")]
        public float Gain2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "GainMod 1")]
        public int GainMod1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "GainMod 2")]
        public int GainMod2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Level 1")]
        public float Level1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Level 2")]
        public float Level2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Presence 1")]
        public float Presence1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Presence 2")]
        public float Presence2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Tone 1")]
        public float Tone1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Tone 2")]
        public float Tone2 { get; set; }

        [DataMember]
        public bool Voltage { get; set; }
    };
}
