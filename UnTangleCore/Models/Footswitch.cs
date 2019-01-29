using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    /// <summary>
    /// Represents the footswitch section of the preset file.
    /// </summary>
    public class Footswitch
    {
        [DataMember]
        public FootswitchDsp Dsp0 { get; set; }

        [DataMember]
        public FootswitchDsp Dsp1 { get; set; }
    };
}
