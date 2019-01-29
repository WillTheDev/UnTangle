using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the 3 Band Comp compressor model.
    /// </summary>
    [DataContract]
    public class Comp3BandComp : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Comp3BandComp()
        {
            DisplayName = ConstDynamics.DISP_3_BAND_COMP;
        }

        [DataMember]
        [JsonProperty(PropertyName = "Hi Gain")]
        public float HiGain { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Lo X Freq")]
        public float LoXFreq { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Mid Thresh")]
        public float MidThresh { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Hi X Freq")]
        public float HiXFreq { get; set; }

        [DataMember]
        public float Release { get; set; }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public bool Detector { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Lo Thresh")]
        public float LoThresh { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Lo Gain")]
        public float LoGain { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Mid Gain")]
        public float MidGain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Ratio { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Hi Thresh")]
        public float HiThresh { get; set; }
    };
}
