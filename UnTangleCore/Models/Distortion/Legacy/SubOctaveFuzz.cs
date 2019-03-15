using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Sub Octave Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class SubOctaveFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SubOctaveFuzz()
        {
            DisplayName = ConstDistortion.DISP_SUB_OCTAVE_FUZZ;
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
        public float Sub { get; set; }
    };
}
