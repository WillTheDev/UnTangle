using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Dynamix Flanger modulation model.
    /// </summary>
    [DataContract]
    public class DynamixFlanger : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DynamixFlanger()
        {
            DisplayName = ConstModulation.DISP_DYNAMIX_FLANGER;
        }

        [DataMember]
        [JsonProperty(PropertyName = "CV Decay")]
        public float CVDecay { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "CV Dynamics")]
        public float CVDynamics { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "CV Tracking")]
        public bool CVTracking { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Control Select")]
        public float ControlSelect { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Env Input")]
        public float EnvInput { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Env Lag")]
        public float EnvLag { get; set; }

        [DataMember]
        public float Manual { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Max Delay")]
        public float MaxDelay { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Phasing { get; set; }

        [DataMember]
        public bool Recycle { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
