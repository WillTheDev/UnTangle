using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Boost Comp compressor model.
    /// </summary>
    [DataContract]
    public class BoostComp : Block
    {
        public BoostComp()
        {
            DisplayName = ConstDynamics.DISP_BOOST_COMP;
            IsLegacy = true;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Comp { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
