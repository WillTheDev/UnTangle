using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Matchstick Jump amp model.
    /// </summary>
    [DataContract]
    public class MatchstickJump : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MatchstickJump()
        {
            DisplayName = ConstAmp.DISP_MATCHSTICK_JUMP;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Ch1Drive { get; set; }

        [DataMember]
        public float Ch2Drive { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
