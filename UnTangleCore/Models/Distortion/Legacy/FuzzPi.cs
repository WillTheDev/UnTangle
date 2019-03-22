using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Fuzz Pi distortion model.
    /// </summary>
    [DataContract]
    public class FuzzPi : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FuzzPi()
        {
            DisplayName = ConstDistortion.DISP_FUZZ_PI;
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
