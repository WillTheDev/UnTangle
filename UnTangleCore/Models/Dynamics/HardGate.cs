using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Hard Gate model.
    /// </summary>
    [DataContract]
    public class HardGate : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public HardGate()
        {
            DisplayName = ConstDynamics.DISP_HARD_GATE;
        }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float HoldTime { get; set; }

        [DataMember]
        public float OpenThreshold { get; set; }

        [DataMember]
        public float CloseThreshold { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
