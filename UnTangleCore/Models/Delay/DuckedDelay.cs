using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Ducked Delay model.
    /// </summary>
    [DataContract]
    public class DuckedDelay : Block
    {
        public DuckedDelay()
        {
            DisplayName = ConstDelay.DISP_DUCKED_DELAY;
        }

        [DataMember]
        public float DynAttack { get; set; }

        [DataMember]
        public float Ducking { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float DynRel { get; set; }

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
        public float Threshold { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool DynType { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
