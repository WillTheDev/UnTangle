using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Matchstick Ch1 model.
    /// </summary>
    [DataContract]
    public class MatchstickCh1 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MatchstickCh1()
        {
            DisplayName = ConstAmp.DISP_MATCHSTICK_CH1;
        }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Ch1Drive { get; set; }
    };
}
