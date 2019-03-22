using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Screamer distortion model.
    /// </summary>
    [DataContract]
    public class Screamer : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Screamer()
        {
            DisplayName = ConstDistortion.DISP_SCREAMER;
            IsLegacy = true;
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
        public float Tone { get; set; }
    };
}
