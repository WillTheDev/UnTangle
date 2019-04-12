using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Tube Comp compressor model.
    /// </summary>
    [DataContract]
    public class TubeComp : Block
    {
        public TubeComp()
        {
            DisplayName = ConstDynamics.DISP_TUBE_COMP;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Thresh { get; set; }
    };
}
