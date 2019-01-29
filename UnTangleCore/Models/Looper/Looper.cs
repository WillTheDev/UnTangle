using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Looper
{
    /// <summary>
    /// Specific settings for the Looper model.
    /// </summary>
    [DataContract]
    public class Looper : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Looper()
        {
            DisplayName = ConstLooper.DISP_LOOPER;
        }
        
        [DataMember]
        public float highCut { get; set; }

        [DataMember]
        public float lowCut { get; set; }

        [DataMember]
		public float Playback { get; set; }

        [DataMember]
		public float Overdub { get; set; }
    };
}
