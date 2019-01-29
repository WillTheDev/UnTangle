using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Essex A30 amp model.
    /// </summary>
    [DataContract]
    public class EssexA30 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public EssexA30()
        {
            DisplayName = ConstAmp.DISP_ESSEX_A30;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
