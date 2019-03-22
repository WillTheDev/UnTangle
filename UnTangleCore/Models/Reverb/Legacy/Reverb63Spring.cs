using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the 63 Spring reverb model.
    /// </summary>
    [DataContract]
    public class Reverb63Spring : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Reverb63Spring()
        {
            DisplayName = ConstReverb.DISP_63_SPRING;
            IsLegacy = true;
        }

        [DataMember]
        public float Predelay { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Decay { get; set; }

    };
}
