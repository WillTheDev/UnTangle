using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the 3 Note Generator synth model.
    /// </summary>
    [DataContract]
    public class Synth3NoteGenerator : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Synth3NoteGenerator()
        {
            DisplayName = ConstPitch.DISP_3_NOTE_GENERATOR;
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
        public float Osc1Glide { get; set; }

        [DataMember]
        public float Osc1Level { get; set; }

        [DataMember]
        public int Osc1Note { get; set; }

        [DataMember]
        public int Osc1Octave { get; set; }

        [DataMember]
        public float Osc1Pan { get; set; }

        [DataMember]
        public int Osc1Shape { get; set; }

        [DataMember]
        public float Osc2Glide { get; set; }

        [DataMember]
        public float Osc2Level { get; set; }

        [DataMember]
        public int Osc2Note { get; set; }

        [DataMember]
        public int Osc2Octave { get; set; }

        [DataMember]
        public float Osc2Pan { get; set; }

        [DataMember]
        public int Osc2Shape { get; set; }

        [DataMember]
        public float Osc3Glide { get; set; }

        [DataMember]
        public float Osc3Level { get; set; }

        [DataMember]
        public int Osc3Note { get; set; }

        [DataMember]
        public int Osc3Octave { get; set; }

        [DataMember]
        public float Osc3Pan { get; set; }

        [DataMember]
        public int Osc3Shape { get; set; }

        [DataMember]
        public bool RiseTimeSwitch { get; set; }
    };
}
