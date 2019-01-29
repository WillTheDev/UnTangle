using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Triangle Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class TriangleFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TriangleFuzz()
        {
            DisplayName = ConstDistortion.MODEL_TRIANGLE_FUZZ;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sustain { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
