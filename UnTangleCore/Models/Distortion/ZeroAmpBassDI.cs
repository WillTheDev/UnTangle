using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Model specific settings for the Zero Amp Bass DI.
    /// </summary>
    [DataContract]
    public class ZeroAmpBassDI : Block
    {
        public ZeroAmpBassDI()
        {
            DisplayName = ConstDistortion.DISP_ZERO_AMP_BASS_DI;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Blend { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
