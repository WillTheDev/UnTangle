using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Buzz Saw distortion model.
    /// </summary>
    [DataContract]
    public class BuzzSaw : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BuzzSaw()
        {
            DisplayName = ConstDistortion.DISP_BUZZ_SAW;
            IsLegacy = true;
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
