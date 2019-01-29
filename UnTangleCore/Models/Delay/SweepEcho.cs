using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Sweep Echo delay model.
    /// </summary>
    [DataContract]
    public class SweepEcho : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SweepEcho()
        {
            DisplayName = ConstDelay.DISP_SWEEP_ECHO;
        }

        [DataMember]
        public float SweepDepth { get; set; }

        [DataMember]
        public float SweepResonance { get; set; }

        [DataMember]
        public int SweepShape { get; set; }

        [DataMember]
        public float SweepSpeed { get; set; }

        [DataMember]
        public float SweepStart { get; set; }

        [DataMember]
        public float SweepSpread { get; set; }

        [DataMember]
        public int FilterType { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public int Scale { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float SweepSymmetry { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
