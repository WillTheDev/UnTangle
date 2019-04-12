using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Red Comp compressor model.
    /// </summary>
    [DataContract]
    public class RedComp : Block
    {
        public RedComp()
        {
            DisplayName = ConstDynamics.DISP_RED_COMP;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sustain { get; set; }
    };
}
