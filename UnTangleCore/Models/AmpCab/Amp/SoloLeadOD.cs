using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Solo Lead OD amp model.
    /// </summary>
    [DataContract]
    public class SoloLeadOD : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SoloLeadOD()
        {
            DisplayName = ConstAmp.DISP_SOLO_LEAD_OD;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
