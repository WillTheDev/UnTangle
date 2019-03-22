using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Dynamic Delay Stereo delay model.
    /// </summary>
    [DataContract]
    public class DynamicDelayStereo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DynamicDelayStereo()
        {
            DisplayName = ConstDelay.DISP_DYNAMIC_DELAY_STEREO;
            IsLegacy = true;
        }

        [DataMember]
        public float Ducking { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Threshold { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
