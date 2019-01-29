using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Low Res delay model.
    /// </summary>
    [DataContract]
    public class LowRes : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public LowRes()
        {
            DisplayName = ConstDelay.DISP_LOW_RES;
        }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Time { get; set; }
        
        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Res { get; set; }
    };
}
