using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    [DataContract(Name = "variax")]
    public class Variax
    {
        [DataMember]
        [JsonProperty(PropertyName = "@variax_volumeknob")]
        public float Variax_Volumeknob { get; set; }


        [DataMember]
        [JsonProperty(PropertyName = "@variax_customtuning")]
        public bool Variax_CustomTuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str1tuning")]
        public int Variax_Str1Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str2tuning")]
        public int Variax_Str2Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str3tuning")]
        public int Variax_Str3Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str4tuning")]
        public int Variax_Str4Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str5tuning")]
        public int Variax_Str5Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_str6tuning")]
        public int Variax_Str6Tuning { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_model")]
        public int Variax_Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_magmode")]
        public bool Variaz_MagMode { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_lockctrls")]
        public int Variax_LockCtrls { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_toneknob")]
        public float Variax_ToneKnob { get; set; }
    };
}
