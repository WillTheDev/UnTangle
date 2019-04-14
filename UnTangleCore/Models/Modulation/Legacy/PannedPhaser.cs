using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Panned Phaser tremolo model.
    /// </summary>
    [DataContract]
    public class PannedPhaser : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PannedPhaser()
        {
            DisplayName = ConstModulation.DISP_PANNED_PHASER;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Pan { get; set; }

        [DataMember]
        public float Speed { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "Pan Speed")]
        public float PanSpeed { get; set; }
    };
}
