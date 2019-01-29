using System.Runtime.Serialization;
using Newtonsoft.Json;

using UnTangle.Core.Models.AmpCab.Cab;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class Dsp
    {
        [DataMember]
        [JsonProperty(PropertyName = "block0")]
        public Block Block0 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block1")]
        public Block Block1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block2")]
        public Block Block2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block3")]
        public Block Block3 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block4")]
        public Block Block4 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block5")]
        public Block Block5 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block6")]
        public Block Block6 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block7")]
        public Block Block7 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block8")]
        public Block Block8 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block9")]
        public Block Block9 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block10")]
        public Block Block10 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block11")]
        public Block Block11 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block12")]
        public Block Block12 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block13")]
        public Block Block13 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block14")]
        public Block Block14 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "block15")]
        public Block Block15 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "inputA")]
        public Input InputA { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "inputB")]
        public Input InputB { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "outputA")]
        public Output OutputA { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "outputB")]
        public Output OutputB { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "split")]
        public Split Split { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "join")]
        public Join Join { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "cab0")]
        public Block Cab0 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "cab1")]
        public Block Cab1 { get; set; }
    };
}
