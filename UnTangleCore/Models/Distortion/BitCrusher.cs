using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Bit Crusher distortion model.
    /// </summary>
    [DataContract]
    public class BitCrusher : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BitCrusher()
        {
            DisplayName = ConstDistortion.DISP_BIT_CRUSHER;
        }

        [DataMember]
        public float BitDepth { get; set; }

        [DataMember]
        public float CloseThreshold { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float HoldTime { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float OpenThreshold { get; set; }

        [DataMember]
        public float SampleRate { get; set; }
    };
}
