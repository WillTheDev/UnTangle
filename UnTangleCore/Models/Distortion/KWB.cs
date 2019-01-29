using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the KWB distortion model.
    /// </summary>
    [DataContract]
    public class KWB : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public KWB()
        {
            DisplayName = ConstDistortion.DISP_KWB;
        }

        [DataMember]
        public float Asym { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int PullDiode { get; set; }

        [DataMember]
        public int PushDiode { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
