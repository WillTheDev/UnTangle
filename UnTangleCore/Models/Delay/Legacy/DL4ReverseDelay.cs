using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Reverse delay model.
    /// </summary>
    [DataContract]
    public class DL4ReverseDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DL4ReverseDelay()
        {
            DisplayName = ConstDelay.DISP_DL4_REVERSE_DELAY;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float ModSpeed { get; set; }
        
        [DataMember]
        public int SyncSelect1 { get; set; }
        
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
