using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp.Bass
{
    /// <summary>
    /// Specific settings for the Del Sol 300 amp model.
    /// </summary>
    [DataContract]
    public class DelSol300 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DelSol300()
        {
            DisplayName = ConstAmp.DISP_DEL_SOL_300;
        }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "62p5Hz")]
        public float EQ_62p5Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "500Hz")]
        public float EQ_500Hz { get; set; }
        
        [DataMember]
        public bool Contour { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "2kHz")]
        public float EQ_2kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "250Hz")]
        public float EQ_250Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "125Hz")]
        public float EQ_125Hz { get; set; }

        [DataMember]
        public bool Bright { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "1kHz")]
        public float EQ_1kHz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "4kHz")]
        public float EQ_4kHz { get; set; }
    };
}
