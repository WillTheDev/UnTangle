using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Multihead delay model.
    /// </summary>
    [DataContract]
    public class MultiheadDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MultiheadDelay()
        {
            DisplayName = ConstDelay.DISP_MULTIHEAD_DELAY;
            IsLegacy = true;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Heads 1-2")]
        public int Heads1_2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Heads 3-4")]
        public int Heads3_4 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
        
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
