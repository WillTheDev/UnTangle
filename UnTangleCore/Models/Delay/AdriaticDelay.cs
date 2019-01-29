using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Adriatic Delay model.
    /// </summary>
    [DataContract]
    public class AdriaticDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AdriaticDelay()
        {
            DisplayName = ConstDelay.DISP_ADRIATIC_DELAY;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Noise { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "BBD Size")]
        public float BBDSize { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
