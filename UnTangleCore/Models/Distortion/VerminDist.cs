using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Vermin distortion model.
    /// </summary>
    [DataContract]
    public class VerminDist : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public VerminDist()
        {
            DisplayName = ConstDistortion.DISP_VERMIN_DIST;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Filter { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
