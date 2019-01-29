using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the Twin Harmony Pitch model.
    /// </summary>
    [DataContract]
    public class TwinHarmony : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TwinHarmony()
        {
            DisplayName = ConstPitch.DISP_TWIN_HARMONY;
        }

        [DataMember]
        public float IntervalVoice1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float KeyVoice2 { get; set; }

        [DataMember]
        public float ScaleVoice2 { get; set; }

        [DataMember]
        public float KeyVoice1 { get; set; }

        [DataMember]
        public float LevelVoice2 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float IntervalVoice2 { get; set; }

        [DataMember]
        public float PanVoice1 { get; set; }

        [DataMember]
        public float PanVoice2 { get; set; }

        [DataMember]
        public float ScaleVoice1 { get; set; }

        [DataMember]
        public float LevelVoice1 { get; set; }
    };
}
