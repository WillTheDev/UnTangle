using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Model specific settings for the Compulsive Drive.
    /// </summary>
    [DataContract]
    public class CompulsiveDrive : Block
    {
        public CompulsiveDrive()
        {
            DisplayName = ConstDistortion.DISP_COMPULSIVE_DRIVE;
        }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public bool LPHP { get; set; }

        [DataMember]
        public bool Version { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
