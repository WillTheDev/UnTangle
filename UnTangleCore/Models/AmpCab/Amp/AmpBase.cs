using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Common settings specific to the Amp models.
    /// </summary>
    [DataContract]
    public abstract class AmpBase : Block
    {
        [DataMember]
        [JsonProperty(PropertyName = "@bypassvolume")]
        public float Bypassvolume { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cab")]
        public string Cab { get; set; } = null;

        [DataMember]
        public float Master { get; set; }

        [DataMember]
        public float Sag { get; set; }

        [DataMember]
        public float Hum { get; set; }

        [DataMember]
        public float Ripple { get; set; }

        [DataMember]
        public float Bias { get; set; }

        [DataMember]
        public float BiasX { get; set; }
    };
}
