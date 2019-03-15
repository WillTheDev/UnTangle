using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Line6 Distortion distortion model.
    /// </summary>
    [DataContract]
    public class Line6Distortion : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Line6Distortion()
        {
            DisplayName = ConstDistortion.DISP_LINE_6_DISTORTION;
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
