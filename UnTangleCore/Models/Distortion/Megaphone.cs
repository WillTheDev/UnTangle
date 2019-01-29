using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Megaphone distortion model.
    /// </summary>
    [DataContract]
    public class Megaphone : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Megaphone()
        {
            DisplayName = ConstDistortion.DISP_MEGAPHONE;
        }

        [DataMember]
        public float Space { get; set; }

        [DataMember]
        public float Focus { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Grit { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }
    };
}
