using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Tweed Blues Brt amp model.
    /// </summary>
    [DataContract]
    public class TweedBluesBrt : AmpBase
    {
        public TweedBluesBrt()
        {
            DisplayName = ConstAmp.DISP_TWEED_BLUES_BRT;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
