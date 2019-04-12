using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Synth String Synth Pitch model.
    /// </summary>
    [DataContract]
    public class SynthString : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SynthString()
        {
            DisplayName = ConstPitch.DISP_SYNTH_STRING;
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
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

    };
}
