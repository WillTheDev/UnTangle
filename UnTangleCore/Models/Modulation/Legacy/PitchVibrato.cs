using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Pitch Vibrato Modulation model.
    /// </summary>
    [DataContract]
    public class PitchVibrato : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PitchVibrato()
        {
            DisplayName = ConstModulation.DISP_PITCH_VIBRATO;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public bool RiseRiseTimeSwitch { get; set; }

        [DataMember]
        public float Rise { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Volsens { get; set; }
    };
}
