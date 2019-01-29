using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the DSP area of the footswitch section of the preset file.
    /// </summary>
    [DataContract]
    public class FootswitchDsp
    {
        [DataMember]
        public FootswitchBlock Block0 { get; set; }

        [DataMember]
        public FootswitchBlock Block1 { get; set; }

        [DataMember]
        public FootswitchBlock Block2 { get; set; }

        [DataMember]
        public FootswitchBlock Block3 { get; set; }

        [DataMember]
        public FootswitchBlock Block4 { get; set; }

        [DataMember]
        public FootswitchBlock Block5 { get; set; }

        [DataMember]
        public FootswitchBlock Block6 { get; set; }

        [DataMember]
        public FootswitchBlock Block7 { get; set; }

        [DataMember]
        public FootswitchBlock Block8 { get; set; }

        [DataMember]
        public FootswitchBlock Block9 { get; set; }

        [DataMember]
        public FootswitchBlock Block10 { get; set; }

        [DataMember]
        public FootswitchBlock Block11 { get; set; }

        [DataMember]
        public FootswitchBlock Block12 { get; set; }

        [DataMember]
        public FootswitchBlock Block13 { get; set; }

        [DataMember]
        public FootswitchBlock Block14 { get; set; }

        [DataMember]
        public FootswitchBlock Block15 { get; set; }
    };
}
