using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Dual Delay model.
    /// </summary>
    [DataContract]
    public class DualDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DualDelay()
        {
            DisplayName = ConstDelay.DISP_DUAL_DELAY;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Left Time")]
        public float LeftTime { get; set; }

        [DataMember]
        public float LeftFeedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float MixL { get; set; }

        [DataMember]
        public float MixR { get; set; }

        [DataMember]
        public int ModulationMode { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Right Time")]
        public float RightTime { get; set; }

        [DataMember]
        public float RightFeedback { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int SyncSelect2 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool TempoSync2 { get; set; }
    };
}
