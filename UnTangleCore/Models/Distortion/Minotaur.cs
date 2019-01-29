using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Minotaur distortion model.
    /// </summary>
    [DataContract]
    public class Minotaur : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Minotaur()
        {
            DisplayName = ConstDistortion.DISP_MINOTAUR;
        }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
