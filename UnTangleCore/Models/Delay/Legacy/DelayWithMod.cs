using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Delay With Mod delay model.
    /// </summary>
    [DataContract]
    public class DelayWithMod : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DelayWithMod()
        {
            DisplayName = ConstDelay.DISP_DELAY_WITH_MOD;
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
        public float ModSpeed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
