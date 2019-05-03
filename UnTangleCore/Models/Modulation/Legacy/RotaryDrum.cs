using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Rotary Drum Modulation model.
    /// </summary>
    [DataContract]
    public class RotaryDrum : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public RotaryDrum()
        {
            DisplayName = ConstModulation.DISP_ROTARY_DRUM;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Speed { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
