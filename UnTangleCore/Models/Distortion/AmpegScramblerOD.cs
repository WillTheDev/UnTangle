using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Model specific settings for the Ampeg Scrambler OD.
    /// </summary>
    [DataContract]
    public class AmpegScramblerOD : Block
    {
        public AmpegScramblerOD()
        {
            DisplayName = ConstDistortion.DISP_AMPEG_SCRAMBLER_OD;
        }

        [DataMember]
        public float Blend { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
