using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Industrial Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class IndustrialFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public IndustrialFuzz()
        {
            DisplayName = ConstDistortion.DISP_INDUSTRIAL_FUZZ;
        }

        [DataMember]
        public float Compress { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Gate { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public bool Oscillator { get; set; }

        [DataMember]
        public float Stability { get; set; }
    };
}
