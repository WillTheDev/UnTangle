using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Spring reverb model.
    /// </summary>
    [DataContract]
    public class Spring : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Spring()
        {
            DisplayName = ConstReverb.DISP_SPRING;
        }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Predelay { get; set; }
    };
}
