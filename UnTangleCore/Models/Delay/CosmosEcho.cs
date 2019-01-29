using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Cosmic Echo delay model.
    /// </summary>
    [DataContract]
    public class CosmosEcho : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CosmosEcho()
        {
            DisplayName = ConstDelay.DISP_DELAY_COSMOS_ECHO;
        }

        [DataMember]
        public float FBTone { get; set; }

        [DataMember]
        public float Time { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Ramp { get; set; }

        [DataMember]
        public float WowFlutter { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Splice { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public bool DryThru { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public int Mode { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
