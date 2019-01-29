using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Matchstick Ch2 model.
    /// </summary>
    [DataContract]
    public class MatchstickCh2 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MatchstickCh2()
        {
            DisplayName = ConstAmp.DISP_MATCHSTICK_CH2;
        }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Ch2Drive { get; set; }
    };
}
