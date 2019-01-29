using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit Trem Brt amp model.
    /// </summary>
    [DataContract]
    public class BritTremBrt : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BritTremBrt()
        {
            DisplayName = ConstAmp.DISP_BRIT_TREM_BRT;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float BrtDrive { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
