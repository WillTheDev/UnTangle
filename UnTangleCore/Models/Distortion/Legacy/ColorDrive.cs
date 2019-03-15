using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Color Drive distortion model.
    /// </summary>
    [DataContract]
    public class ColorDrive : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ColorDrive()
        {
            DisplayName = ConstDistortion.DISP_COLOR_DRIVE;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}
