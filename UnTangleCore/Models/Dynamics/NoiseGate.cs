using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Noise Gate model.
    /// </summary>
    [DataContract]
    public class NoiseGate : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public NoiseGate()
        {
            DisplayName = ConstDynamics.DISP_NOISE_GATE;
        }

        [DataMember]
        public int Threshold { get; set; }

        [DataMember]
		public float Level { get; set; }
		
        [DataMember]
        public float Decay { get; set; }
    };
}
