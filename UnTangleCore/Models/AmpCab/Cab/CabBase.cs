using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Contains common settings for Cab models.
    /// </summary>
    [DataContract]
    public abstract class CabBase : Block
    {
        [DataMember]
        [JsonProperty(PropertyName = "@mic")]
        public int Mic { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float EarlyReflections { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Distance { get; set; }

        [DataMember]
        public float HighCut { get; set; }
    };
}
