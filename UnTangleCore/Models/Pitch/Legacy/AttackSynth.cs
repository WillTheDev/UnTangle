using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Attack Synth Synth Pitch model.
    /// </summary>
    [DataContract]
    public class AttackSynth : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AttackSynth()
        {
            DisplayName = ConstPitch.DISP_ATTACK_SYNTH;
            IsLegacy = true;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Pitch { get; set; }

        [DataMember]
        public int Wave { get; set; }

    };
}
