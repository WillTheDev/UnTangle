using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Blue Comp Treble compressor model.
    /// </summary>
    [DataContract]
    public class BlueCompTreb : Block
    {
        public BlueCompTreb()
        {
            DisplayName = ConstDynamics.DISP_BLUE_COMP_TREB;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sustain { get; set; }
    };
}
