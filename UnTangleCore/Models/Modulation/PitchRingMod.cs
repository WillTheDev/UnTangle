using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Pitch Ring Mod modulation model.
    /// </summary>
    [DataContract]
    public class PitchRingMod : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PitchRingMod()
        {
            DisplayName = ConstModulation.DISP_PITCH_RING_MOD;
        }
        
        [DataMember]
        public float DutyCycle { get; set; }

        [DataMember]
        public float FMAmount { get; set; }

        [DataMember]
        public float FMDuty { get; set; }

        [DataMember]
        public int FMOctave { get; set; }

        [DataMember]
        public float FMPitch { get; set; }

        [DataMember]
        public float FMShape { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int Octave { get; set; }

        [DataMember]
        public float Pitch { get; set; }

        [DataMember]
        public float Shape { get; set; }
    };
}
