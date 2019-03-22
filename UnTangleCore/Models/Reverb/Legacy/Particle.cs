using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Particle reverb model.
    /// </summary>
    [DataContract]
    public class Particle : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Particle()
        {
            DisplayName = ConstReverb.DISP_PARTICLE;
            IsLegacy = true;
        }

        [DataMember]
        public float Condition { get; set; }

        [DataMember]
        public float Dwell { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }
    };
}
