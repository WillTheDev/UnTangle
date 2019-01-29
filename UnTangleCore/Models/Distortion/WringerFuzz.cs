using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Wringer Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class WringerFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public WringerFuzz()
        {
            DisplayName = ConstDistortion.DISP_WRINGER_FUZZ;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float FuzzType { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
