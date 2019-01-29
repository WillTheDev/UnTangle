using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    [DataContract]
    [JsonConverter(typeof(BlockModelConverter))]
    public class Block
    {
        /// <summary>
        /// Friendly name of the model that is loaded in the block.
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// Model identifier.
        /// </summary>
        [DataMember]
        [JsonProperty(PropertyName = "@model")]
        public string Model { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@position")]
        public int Position { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@enabled")]
        public bool Enabled { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@path")]
        public int Path { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@type")]
        public int Type { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@stereo")]
        public bool Stereo { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "@trails")]
        public bool Trails { get; set; }

        /// <summary>
        /// String representation of the model type.
        /// </summary>
        public string ModelType
        {
            get
            {
                return (ModelTypeHelper.ParseModelType(Type));
            }
        }
    };
}
