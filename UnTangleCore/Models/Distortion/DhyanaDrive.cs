using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Model specific settings for the Dhyana Drive.
    /// </summary>
    [DataContract]
    public class DhyanaDrive : Block
    {
        public DhyanaDrive()
        {
            DisplayName = ConstDistortion.DISP_DHYANA_DRIVE;
        }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Voice { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
