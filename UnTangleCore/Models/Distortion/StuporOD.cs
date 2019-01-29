using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Stupor OD distortion model.
    /// </summary>
    [DataContract]
    public class StuporOD : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public StuporOD()
        {
            DisplayName = ConstDistortion.DISP_STUPOR_OD;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
