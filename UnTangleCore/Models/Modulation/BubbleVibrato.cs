using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Bubble Vibrato Mod modulation model.
    /// </summary>
    [DataContract]
    public class BubbleVibrato : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BubbleVibrato()
        {
            DisplayName = ConstModulation.DISP_BUBBLE_VIBRATO;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float RiseTime { get; set; }

        [DataMember]
        public bool RiseTimeSwitch { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
