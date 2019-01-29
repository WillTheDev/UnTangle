using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class SnapshotController
    {
        [DataMember]
        public SnapshotDsp Dsp0 { get; set; }

        [DataMember]
        public Tuple<string, List<Dictionary<string, string>>> Dsp1 { get; set; }
    };
}
