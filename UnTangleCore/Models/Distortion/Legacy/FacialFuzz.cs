using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Facial Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class FacialFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FacialFuzz()
        {
            DisplayName = ConstDistortion.DISP_FACIAL_FUZZ;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public float Drive { get; set; }
    };
}
