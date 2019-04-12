using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics.Legacy
{
    /// <summary>
    /// Specific settings for the Vetta Juice compressor model.
    /// </summary>
    [DataContract]
    public class VettaJuice : Block
    {
        public VettaJuice()
        {
            DisplayName = ConstDynamics.DISP_VETTA_JUICE;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Amount { get; set; }
    };
}
