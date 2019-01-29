using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit J45 Brt amp model.
    /// </summary>
    [DataContract]
    public class BritJ45Brt : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BritJ45Brt()
        {
            DisplayName = ConstAmp.DISP_BRIT_J45_BRT;
        }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}
