using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Hedgehog D9 distortion model.
    /// </summary>
    [DataContract]
    public class HedgehogD9 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public HedgehogD9()
        {
            DisplayName = ConstDistortion.DISP_HEDGEHOG_D9;
        }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
