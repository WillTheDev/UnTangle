using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Simple Delay model.
    /// </summary>
    [DataContract]
    public class SimpleDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SimpleDelay()
        {
            DisplayName = ConstDelay.DISP_SIMPLE_DELAY;
        }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
		public bool TempoSync1 { get; set; }

        [DataMember]
		public float Time { get; set; }

        [DataMember]
		public int SyncSelect1 { get; set; }

        [DataMember]
		public float Mix { get; set; }

        [DataMember]
		public float Feedback { get; set; }
    };
}
