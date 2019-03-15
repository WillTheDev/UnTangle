using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Classic Distortion distortion model.
    /// </summary>
    [DataContract]
    public class ClassicDistortion : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ClassicDistortion()
        {
            DisplayName = ConstDistortion.DISP_CLASSIC_DISTORTION;
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
        public float Filter { get; set; }
    };
}
