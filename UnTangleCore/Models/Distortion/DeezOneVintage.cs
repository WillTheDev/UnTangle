using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Deez One Vintage distortion model.
    /// </summary>
    [DataContract]
    public class DeezOneVintage : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DeezOneVintage()
        {
            DisplayName = ConstDistortion.DISP_DEEZ_ONE_VINTAGE;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }

    };
}
