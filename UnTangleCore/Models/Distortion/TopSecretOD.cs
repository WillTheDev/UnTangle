using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Top Secret OD distortion model.
    /// </summary>
    [DataContract]
    public class TopSecretOD : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TopSecretOD()
        {
            DisplayName = ConstDistortion.DISP_TOP_SECRET_OD;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
