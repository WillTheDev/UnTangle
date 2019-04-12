using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Two Voice Harmony Pitch model.
    /// </summary>
    [DataContract]
    public class TwoVoiceHarmony : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TwoVoiceHarmony()
        {
            DisplayName = ConstPitch.DISP_TWO_VOICE_HARMONY;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int Key { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int Scale { get; set; }

        [DataMember]
        public int Shift { get; set; }

    };
}
