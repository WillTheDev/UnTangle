using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the PV Panama amp model.
    /// </summary>
    [DataContract]
    public class PVPanama : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PVPanama()
        {
            DisplayName = ConstAmp.DISP_PV_PANAMA;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Resonance { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}
