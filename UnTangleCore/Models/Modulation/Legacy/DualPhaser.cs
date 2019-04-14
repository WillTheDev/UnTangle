using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Dual Phaser Tremolo model.
    /// </summary>
    [DataContract]
    public class DualPhaser : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DualPhaser()
        {
            DisplayName = ConstModulation.DISP_DUAL_PHASER;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public bool LFOShape { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Speed { get; set; }
    };
}
