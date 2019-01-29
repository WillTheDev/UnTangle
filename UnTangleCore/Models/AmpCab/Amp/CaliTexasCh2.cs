using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Cali Texas Ch2 amp model.
    /// </summary>
    [DataContract]
    public class CaliTexasCh2 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CaliTexasCh2()
        {
            DisplayName = ConstAmp.DISP_CALI_TEXAS_CH2;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive 1")]
        public float Drive1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive 2")]
        public float Drive2 { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "TS Shape")]
        public float TSShape { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
