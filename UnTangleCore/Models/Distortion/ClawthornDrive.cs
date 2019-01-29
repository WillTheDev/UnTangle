using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Clawthorn Drive distortion model.
    /// </summary>
    [DataContract]
    public class ClawthornDrive : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ClawthornDrive()
        {
            DisplayName = ConstDistortion.DISP_CLAWTHORN_DRIVE;
        }

        [DataMember]
        public bool Fuzz { get; set; }

        [DataMember]
        public float FuzzGain { get; set; }

        [DataMember]
        public float FuzzLevel { get; set; }

        [DataMember]
        public bool FuzzOct { get; set; }

        [DataMember]
        public float FuzzTone { get; set; }

        [DataMember]
        public float ODGain { get; set; }

        [DataMember]
        public float ODLevel { get; set; }

        [DataMember]
        public bool ODLowBoost { get; set; }

        [DataMember]
        public float ODTone { get; set; }
    };
}
