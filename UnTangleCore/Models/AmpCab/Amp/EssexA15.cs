using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Essex A15 amp model.
    /// </summary>
    [DataContract]
    public class EssexA15 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public EssexA15()
        {
            DisplayName = ConstAmp.DISP_ESSEX_A15;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
