using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Harmonic tremolo model.
    /// </summary>
    [DataContract]
    public class HarmonicTremolo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public HarmonicTremolo()
        {
            DisplayName = ConstModulation.DISP_HARMONIC_TREM;
        }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float DutyCycle { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float BassFreq { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float TrebFreq { get; set; }

        [DataMember]
        public int WaveShape { get; set; }
    };
}
