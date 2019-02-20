using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Ducking reverb model.
    /// </summary>
    [DataContract]
    public class Ducking : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Ducking()
        {
            DisplayName = ConstReverb.DISP_DUCKING;
        }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Predelay { get; set; }
    };
}
