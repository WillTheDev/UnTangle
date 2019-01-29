using System.Runtime.Serialization;

using Newtonsoft.Json;
namespace UnTangle.Core.Models
{
    [DataContract]
    public class Global
    {
        [DataMember]
        [JsonProperty(PropertyName = "@variax_volumeknob")]
        public float Variax_Volumeknob { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@pedalstate")]
        public int Pedalstate { get; set; }

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
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@topology0")]
        public string Topology0 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_dsp")]
        public int Cursor_DSP { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@guitarinputZ")]
        public int GuitarInputZ { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@tempo")]
        public double Tempo { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@topology1")]
        public string Topology1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_magmode")]
        public bool Variaz_MagMode { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_lockctrls")]
        public int Variax_LockCtrls { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@variax_toneknob")]
        public float Variax_ToneKnob { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@current_snapshot")]
        public int CurrentSnapshot { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_group")]
        public string Cursor_Group { get; set; }
    };
}
