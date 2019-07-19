using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Fullerton Jump amp model.
    /// </summary>
    [DataContract]
    public class FullertonJump : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FullertonJump()
        {
            DisplayName = ConstAmp.DISP_FULLERTON_JUMP;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float DriveBright { get; set; }

        [DataMember]
        public float DriveNorm { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
