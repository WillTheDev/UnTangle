using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Blue Comp compressor model.
    /// </summary>
    [DataContract]
    public class BlueComp : Block
    {
        public BlueComp()
        {
            DisplayName = ConstDynamics.DISP_BLUE_COMP;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sustain { get; set; }
    };
}
