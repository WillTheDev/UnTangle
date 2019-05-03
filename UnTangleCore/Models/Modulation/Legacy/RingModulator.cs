using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Ring Modulator Modulation model.
    /// </summary>
    [DataContract]
    public class RingModulator : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public RingModulator()
        {
            DisplayName = ConstModulation.DISP_RING_MODULATOR;
            IsLegacy = true;
        }

        [DataMember]
        [JsonProperty(PropertyName = "AM/FM")]
        public float AM_FM { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Shape { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
