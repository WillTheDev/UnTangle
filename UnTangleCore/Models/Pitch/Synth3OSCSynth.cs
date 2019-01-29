using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the 3 OSC Synth model.
    /// </summary>
    [DataContract]
    public class Synth3OSCSynth : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Synth3OSCSynth()
        {
            DisplayName = ConstPitch.DISP_3_OSC_SYNTH;
        }

        [DataMember]
        public float DutyVoice1 { get; set; }

        [DataMember]
        public float DutyVoice2 { get; set; }

        [DataMember]
        public float DutyVoice3 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "FM Voice3to1")]
        public float FMVoice3to1 { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LevelVoice1 { get; set; }

        [DataMember]
        public float LevelVoice2 { get; set; }

        [DataMember]
        public float LevelVoice3 { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int OctaveVoice1 { get; set; }

        [DataMember]
        public int OctaveVoice2 { get; set; }

        [DataMember]
        public int OctaveVoice3 { get; set; }

        [DataMember]
        public float PanVoice1 { get; set; }

        [DataMember]
        public float PanVoice2 { get; set; }

        [DataMember]
        public float PanVoice3 { get; set; }

        [DataMember]
        public float PitchVoice1 { get; set; }

        [DataMember]
        public float PitchVoice2 { get; set; }

        [DataMember]
        public float PitchVoice3 { get; set; }

        [DataMember]
        public float ShapeVoice1 { get; set; }

        [DataMember]
        public float ShapeVoice2 { get; set; }

        [DataMember]
        public float ShapeVoice3 { get; set; }

        [DataMember]
        public int SynthPreset { get; set; }
    };
}
