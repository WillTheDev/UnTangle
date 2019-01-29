using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Chamber reverb model.
    /// </summary>
    [DataContract]
    public class Chamber : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Chamber()
        {
            DisplayName = ConstReverb.DISP_CHAMBER;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
		public float Predelay { get; set; }
					
        [DataMember]
		public float Level { get; set; }
		
        [DataMember]
		public float LowCut { get; set; }

        [DataMember]
		public float Decay { get; set; }

        [DataMember]
		public float HighCut { get; set; }

    };
}
