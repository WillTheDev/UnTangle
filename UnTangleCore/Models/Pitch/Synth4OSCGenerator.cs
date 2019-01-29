using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the 4 OSC Generator synth model.
    /// </summary>
    [DataContract]
    public class Synth4OSCGenerator : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Synth4OSCGenerator()
        {
            DisplayName = ConstPitch.DISP_4_OSC_GENERATOR;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float DryLevel { get; set; }

        [DataMember]
        public float DryPan { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Osc1Freq { get; set; }

        [DataMember]
        public float Osc1Level { get; set; }

        [DataMember]
        public float Osc1Pan { get; set; }

        [DataMember]
        public int Osc1Shape { get; set; }

        [DataMember]
        public float Osc2Freq { get; set; }

        [DataMember]
        public float Osc2Level { get; set; }

        [DataMember]
        public float Osc2Pan { get; set; }

        [DataMember]
        public int Osc2Shape { get; set; }

        [DataMember]
        public float Osc3Freq { get; set; }

        [DataMember]
        public float Osc3Level { get; set; }

        [DataMember]
        public float Osc3Pan { get; set; }

        [DataMember]
        public int Osc3Shape { get; set; }

        [DataMember]
        public float Osc4Freq { get; set; }

        [DataMember]
        public float Osc4Level { get; set; }

        [DataMember]
        public float Osc4Pan { get; set; }

        [DataMember]
        public int Osc4Shape { get; set; }

        [DataMember]
        public bool RiseTimeSwitch { get; set; }
    };
}
