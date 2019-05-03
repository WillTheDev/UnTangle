using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Rotary Drum Horn Modulation model.
    /// </summary>
    [DataContract]
    public class RotaryDrumHorn : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public RotaryDrumHorn()
        {
            DisplayName = ConstModulation.DISP_ROTARY_DRUM_HORN;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Horn Depth")]
        public float HornDepth { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Speed { get; set; }
    };
}
