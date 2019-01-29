using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp.Bass
{
    /// <summary>
    /// Specific settings for the SV Beast Brt bass amp model.
    /// </summary>
    [DataContract]
    public class SVBeastBrt : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SVBeastBrt()
        {
            DisplayName = ConstAmp.DISP_SV_BEAST_BRT;
        }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float MidFreq { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
