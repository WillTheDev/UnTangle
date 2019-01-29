using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Divided Duo amp model.
    /// </summary>
    [DataContract]
    public class DividedDuo : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DividedDuo()
        {
            DisplayName = ConstAmp.DISP_DIVIDED_DUO;
        }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive 1")]
        public float Drive1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive 2")]
        public float Drive2 { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
