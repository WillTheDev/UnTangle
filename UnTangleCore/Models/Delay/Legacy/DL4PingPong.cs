using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Ping Pong delay model.
    /// </summary>
    [DataContract]
    public class DL4PingPong : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DL4PingPong()
        {
            DisplayName = ConstDelay.DISP_DL4_PING_PONG;
            IsLegacy = true;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }
        
        [DataMember]
        public float Offset { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Time { get; set; }
              
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Spread { get; set; }
    };
}
