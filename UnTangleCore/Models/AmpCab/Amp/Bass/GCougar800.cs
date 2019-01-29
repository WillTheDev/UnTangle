using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp.Bass
{
    /// <summary>
    /// Specific settings for the GCougar 800 bass amp model.
    /// </summary>
    [DataContract]
    public class GCougar800 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public GCougar800()
        {
            DisplayName = ConstAmp.DISP_GCOUGAR_800;
        }

        [DataMember]
        public float HighMid { get; set; }

        [DataMember]
        public float LowMid { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public bool Contour { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Boost { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
