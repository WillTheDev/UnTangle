using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Jazz Rivet 120 amp model.
    /// </summary>
    [DataContract]
    public class JazzRivet120 : AmpBase
    {
        /// <summary>
        /// CTOR. Sets the display name.
        /// </summary>
        public JazzRivet120()
        {
            DisplayName = ConstAmp.DISP_JAZZ_RIVET_120;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public int Bright { get; set; }
               
        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
