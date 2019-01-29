using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Tremolo model.
    /// </summary>
    [DataContract]
    public class Tremolo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Tremolo()
        {
            DisplayName = ConstModulation.DISP_TREMOLO;
        }

        [DataMember]
        public float DutyCycle { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int WaveShape { get; set; }
    };
}
