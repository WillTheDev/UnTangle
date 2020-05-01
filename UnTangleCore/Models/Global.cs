using System.Runtime.Serialization;

using Newtonsoft.Json;
namespace UnTangle.Core.Models
{
    [DataContract]
    public class Global
    {
        [DataMember]
        [JsonProperty(PropertyName = "@DtSelect")]
        public int DtSelect { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@PowercabMode")]
        public int PowercabMode { get; set; }
    
        [DataMember]
        [JsonProperty(PropertyName = "@PowercabSelect")]
        public int PowercabSelect { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@PowercabVoicing")]
        public int PowercabVoicing { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@current_snapshot")]
        public int CurrentSnapshot { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_dsp")]
        public int CursorDsp { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_group")]
        public string CursorGroup { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_path")]
        public int CursorPath { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@cursor_position")]
        public int CursorPosition { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@guitarinputZ")]
        public int GuitarInputZ { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@pedalstate")]
        public int Pedalstate { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@tempo")]
        public decimal Tempo { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@topology0")]
        public string Topology0 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@topology1")]
        public string Topology1 { get; set; }


        
    };
}
