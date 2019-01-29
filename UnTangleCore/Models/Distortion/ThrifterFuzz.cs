using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Thrifter Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class ThrifterFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ThrifterFuzz()
        {
            DisplayName = ConstDistortion.DISP_THRIFTER_FUZZ;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        [JsonProperty(PropertyName ="Notch Freq")]
        public float NotchFreq { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Notch Gain")]
        public float NotchGain { get; set; }

        [DataMember]
        public int Thick { get; set; }
    };
}
