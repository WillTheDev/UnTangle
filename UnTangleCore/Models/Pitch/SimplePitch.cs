using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the Simple Pitch model.
    /// </summary>
    [DataContract]
    public class SimplePitch : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SimplePitch()
        {
            DisplayName = ConstPitch.DISP_SIMPLE_PITCH;
        }

        [DataMember]
        public int Cents1 { get; set; }

        [DataMember]
        public float Time1 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float LevelVoice1 { get; set; }

        [DataMember]
        public int Interval1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float PanVoice1 { get; set; }

        [DataMember]
        public float PanDry { get; set; }
    };
}
