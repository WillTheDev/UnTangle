using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Hall reverb model.
    /// </summary>
    [DataContract]
    public class Hall : Block
    {
        /// <summary>
        /// CTOR.  Sets the device name.
        /// </summary>
        public Hall()
        {
            DisplayName = ConstReverb.DISP_HALL;
        }

        [DataMember]
        public float HighCut { get; set; }

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
    };
}
