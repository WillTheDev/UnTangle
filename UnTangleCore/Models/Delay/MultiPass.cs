using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Multipass delay model.
    /// </summary>
    [DataContract]
    public class MultiPass : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MultiPass()
        {
            DisplayName = ConstDelay.DISP_DELAY_MULTI_PASS;
        }

        [DataMember]
        public int Pattern { get; set; }

        [DataMember]
        public float Tap3Pan { get; set; }

        [DataMember]
        public float Tap2Pan { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Tap6Pan { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Tap1Pan { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Tap5Pan { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Tap4Pan { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
