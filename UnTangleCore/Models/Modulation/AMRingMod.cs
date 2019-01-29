using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the AM Ring Mod modulation model.
    /// </summary>
    [DataContract]
    public class AMRingMod : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AMRingMod()
        {
            DisplayName = ConstModulation.DISP_AM_RING_MOD;
        }

        [DataMember]
        public bool AM { get; set; }

        [DataMember]
        public float AMFreq { get; set; }

        [DataMember]
        public float Frequency { get; set; }

        [DataMember]
        public bool LFO { get; set; }

        [DataMember]
        public float LFORate { get; set; }

        [DataMember]
        public int LFOShape { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
