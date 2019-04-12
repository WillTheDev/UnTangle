using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Octi Synth Pitch model.
    /// </summary>
    [DataContract]
    public class OctiSynth : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public OctiSynth()
        {
            DisplayName = ConstPitch.DISP_OCTI_SYNTH;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        public int Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

    };
}
