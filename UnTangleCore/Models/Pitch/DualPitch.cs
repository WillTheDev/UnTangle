using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the Dual Pitch model.
    /// </summary>
    [DataContract]
    public class DualPitch : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DualPitch()
        {
            DisplayName = ConstPitch.DISP_DUAL_PITCH;
        }

        [DataMember]
        public float Interval1 { get; set; }

        [DataMember]
        public float PanVoice1 { get; set; }

        [DataMember]
        public float Interval2 { get; set; }

        [DataMember]
        public float Time1 { get; set; }

        [DataMember]
        public int Cents1 { get; set; }
        
        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float PanDry { get; set; }

        [DataMember]
        public int Cents2 { get; set; }

        [DataMember]
        public float Time2 { get; set; }

        [DataMember]
        public float LevelVoice1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float PanVoice2 { get; set; }

        [DataMember]
        public float LevelVoice2 { get; set; }
    };
}
