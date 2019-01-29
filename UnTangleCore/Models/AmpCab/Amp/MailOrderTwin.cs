using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Mail Order Twin amp model.
    /// </summary>
    [DataContract]
    public class MailOrderTwin : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MailOrderTwin()
        {
            DisplayName = ConstAmp.DISP_MAIL_ORDER_TWIN;
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
