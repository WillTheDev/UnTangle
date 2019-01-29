using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Teemah distortion model.
    /// </summary>
    [DataContract]
    public class Teemah : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Teemah()
        {
            DisplayName = ConstDistortion.DISP_TEEMAH;
        }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Clipping { get; set; }

        [DataMember]
        public float Level { get; set; }
        
        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
