using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Jumbo Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class JumboFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public JumboFuzz()
        {
            DisplayName = ConstDistortion.DISP_JUMBO_FUZZ;
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
        public float Mid { get; set; }
    };
}
