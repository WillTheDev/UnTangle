using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Auto Swell compressor model.
    /// </summary>
    [DataContract]
    public class AutoSwell : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AutoSwell()
        {
            DisplayName = ConstDynamics.DISP_AUTO_SWELL;
        }

        [DataMember]
        [JsonProperty(PropertyName = "Rel Offset")]
        public float RelOffset { get; set; }

        [DataMember]
		public float Threshold { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
		public bool Taper { get; set; }

        [DataMember]
		public float Decay { get; set; }

        [DataMember]
		public float Attack { get; set; }
    };
}
