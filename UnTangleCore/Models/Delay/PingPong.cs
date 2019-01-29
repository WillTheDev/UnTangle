using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Ping Pong delay model.
    /// </summary>
    [DataContract]
    public class PingPong : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PingPong()
        {
            DisplayName = ConstDelay.DISP_PING_PONG;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }

    };
}
