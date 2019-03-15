using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Line6 Drive distortion model.
    /// </summary>
    [DataContract]
    public class Line6Drive : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Line6Drive()
        {
            DisplayName = ConstDistortion.DISP_LINE_6_DRIVE;
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
