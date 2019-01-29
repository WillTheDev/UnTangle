using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Double Take Mod modulation model.
    /// </summary>
    [DataContract]
    public class DoubleTake : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DoubleTake()
        {
            DisplayName = ConstModulation.DISP_DOUBLE_TAKE;
        }

        [DataMember]
        public float Doubles { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Dry Level")]
        public float DryLevel { get; set; }

        [DataMember]
        public float Sensitivity { get; set; }

        [DataMember]
        public float Slop { get; set; }

        [DataMember]
        public float Source { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Wet Level")]
        public float WetLevel { get; set; }
    };
}
