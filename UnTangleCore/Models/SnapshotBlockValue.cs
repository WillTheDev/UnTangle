using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    [DataContract]
    [JsonDictionary]
    public class SnapshotBlockValue : Dictionary<string, Dictionary<string, string>>
    {
        [DataMember]
        public string Parameter { get; set; }

        [DataMember]
        public Dictionary<string, string> ParamValues { get; set; }
    };
}
