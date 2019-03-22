using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Auto Vol delay model.
    /// </summary>
    [DataContract]
    public class AutoVolDelay : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AutoVolDelay()
        {
            DisplayName = ConstDelay.DISP_AUTO_VOL_DELAY;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Swell { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
        
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
