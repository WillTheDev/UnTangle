using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb
{
    /// <summary>
    /// Specific settings for the Double Tank reverb model.
    /// </summary>
    [DataContract]
    public class DoubleTank : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DoubleTank()
        {
            DisplayName = ConstReverb.DISP_DOUBLE_TANK;
        }

        [DataMember]
        public float LowCut { get; set; }
        
        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public int Predelay { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Modulation { get; set; }
    };
}
