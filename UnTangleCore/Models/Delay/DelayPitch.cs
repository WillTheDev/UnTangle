using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Delay Pitch delay model.
    /// </summary>
    [DataContract]
    public class DelayPitch : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DelayPitch()
        {
            DisplayName = ConstDelay.DISP_DELAY_PITCH;
        }

        [DataMember]
        public float Cents1 { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int Scale { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Time { get; set; }

        [DataMember]
        public int Interval1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float HighCut { get; set; }
    };
}
