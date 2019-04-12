using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Vetta Comp compressor model.
    /// </summary>
    [DataContract]
    public class VettaComp : Block
    {
        public VettaComp()
        {
            DisplayName = ConstDynamics.DISP_VETTA_COMP;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sens { get; set; }
    };
}
