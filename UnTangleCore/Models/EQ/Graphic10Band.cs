using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the 10 band EQ model.
    /// </summary>
    [DataContract]
    public class Graphic10Band : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Graphic10Band()
        {
            DisplayName = ConstEQ.DISP_GRAPHIC_10_BAND;
        }

        [DataMember]
        [JsonProperty(PropertyName = "8kHz")]
        public float Band_8kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "2kHz")]
        public float Band_2kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "62p5Hz")]
        public float Band_62p5Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "4kHz")]
        public float Band_4kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "500Hz")]
        public float Band_500Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "1kHz")]
        public float Band_1kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "31p25Hz")]
        public float Band_31p25Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "16kHz")]
        public float Band_16kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "125Hz")]
        public float Band_125Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "250Hz")]
        public float Band_250Hz { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
