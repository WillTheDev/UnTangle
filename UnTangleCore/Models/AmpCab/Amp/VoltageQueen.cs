using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Voltage Queen amp model.
    /// </summary>
    [DataContract]
    public class VoltageQueen : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public VoltageQueen()
        {
            DisplayName = ConstAmp.DISP_VOLTAGE_QUEEN;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive 1")]
        public float Drive1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Drive Trem")]
        public float DriveTrem { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
