using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit P75 Brt amp Model.
    /// </summary>
    [DataContract]
    public class BritP75Brt : AmpBase
    {
        public BritP75Brt()
        {
            /// <summary>
            /// CTOR.  Sets the display name.
            /// </summary>
            DisplayName = ConstAmp.DISP_BRIT_P75_BRT;
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
