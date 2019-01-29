using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Arbitrator Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class ArbitratorFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ArbitratorFuzz()
        {
            DisplayName = ConstDistortion.DISP_ARBITRATOR_FUZZ;
        }

        [DataMember]
        public float Fuzz { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
