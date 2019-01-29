using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Harmony Delay model.
    /// </summary>
    [DataContract]
    public class HarmonyDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public HarmonyDelay()
        {
            DisplayName = ConstDelay.DISP_HARMONY_DELAY;
        }

        [DataMember]
        public float DelayVoice1 { get; set; }

        [DataMember]
        public float DelayVoice2 { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public int IntervalVoice1 { get; set; }

        [DataMember]
        public int IntervalVoice2 { get; set; }

        [DataMember]
        public int Key { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LevelRootVoice { get; set; }

        [DataMember]
        public float LevelVoice1 { get; set; }

        [DataMember]
        public float LevelVoice2 { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float PanRootVoice { get; set; }

        [DataMember]
        public float PanVoice1 { get; set; }

        [DataMember]
        public float PanVoice2 { get; set; }

        [DataMember]
        public int Scale { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
