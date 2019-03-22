using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Octo reverb model.
    /// </summary>
    [DataContract]
    public class Octo : Block
    {
        /// <summary>
        /// CTOR.  Sets the device name.
        /// </summary>
        public Octo()
        {
            DisplayName = ConstReverb.DISP_OCTO;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }
					
        [DataMember]
        public float Intensity { get; set; }
					
        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float HighCut { get; set; }
					
        [DataMember]
        public float Mix { get; set; }
    };
}
