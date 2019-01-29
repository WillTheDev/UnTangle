using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Cali Q EQ model.
    /// </summary>
    [DataContract]
    public class CaliQ : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CaliQ()
        {
            DisplayName = ConstEQ.DISP_CALI_Q;
        }

        [DataMember]
        [JsonProperty (PropertyName = "6600Hz")]
        public float Band_6600Hz { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "240Hz")]
        public float Band_240Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "750Hz")]
        public float Band_750Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "80Hz")]
        public float Band_80Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "2200Hz")]
        public float Band_2200Hz { get; set; }
    };
}
