using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Adriatic Swell delay model.
    /// </summary>
    [DataContract]
    public class AdriaticSwell : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AdriaticSwell()
        {
            DisplayName = ConstDelay.DISP_ADRIATIC_SWELL;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "BBD Size")]
        public float BBDSize { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Noise { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
        
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Threshold { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
