using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Deez One Mod distortion model.
    /// </summary>
    [DataContract]
    public class DeezOneMod : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DeezOneMod()
        {
            DisplayName = ConstDistortion.DISP_DEEZ_ONE_MOD;
        }

        [DataMember]
        public bool Clipping { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
