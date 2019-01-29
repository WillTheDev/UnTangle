using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Kinky Boost model.
    /// </summary>
    [DataContract]
    public class KinkyBoost : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public KinkyBoost()
        {
            DisplayName = ConstDistortion.DISP_KINKY_BOOST;
        }

        [DataMember]
        public bool Bright { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public bool Boost { get; set; }
    };
}
