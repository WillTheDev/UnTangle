using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Stereo Delay delay model.
    /// </summary>
    [DataContract]
    public class StereoDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public StereoDelay()
        {
            DisplayName = ConstDelay.DISP_STEREO_DELAY;
            IsLegacy = true;
        }

        [DataMember]
        public float LFeedback { get; set; }

        [DataMember]
        public float LTime { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float RFeedback { get; set; }

        [DataMember]
        public float RTime { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int SyncSelect2 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool TempoSync2 { get; set; }
    };
}
