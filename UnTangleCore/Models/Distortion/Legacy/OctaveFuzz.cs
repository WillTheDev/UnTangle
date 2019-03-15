using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Octave Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class OctaveFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public OctaveFuzz()
        {
            DisplayName = ConstDistortion.DISP_OCTAVE_FUZZ;
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
