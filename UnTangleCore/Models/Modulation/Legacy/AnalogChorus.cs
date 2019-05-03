using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Analog Chorus Modulation model.
    /// </summary>
    [DataContract]
    public class AnalogChorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AnalogChorus()
        {
            DisplayName = ConstModulation.DISP_ANALOG_CHORUS;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "CH Vib")]
        public bool CHVib { get; set; }

        [DataMember]
        public int Tone { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Speed { get; set; }
    };
}
