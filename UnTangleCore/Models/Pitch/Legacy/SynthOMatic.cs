using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Synth O-Matic Synth Pitch model.
    /// </summary>
    [DataContract]
    public class SynthOMatic : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SynthOMatic()
        {
            DisplayName = ConstPitch.DISP_SYNTH_OMATIC;
            IsLegacy = true;
        }

        [DataMember]
        public float Frequency { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        public float Pitch { get; set; }

        [DataMember]
        public int Wave { get; set; }

    };
}
