using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class SnapshotBlockState
    {
        [DataMember]
        public Dictionary<string, bool> Dsp0 { get; set; }

        [DataMember]
        public Dictionary<string, bool> Dsp1 { get; set; }
    };
}
