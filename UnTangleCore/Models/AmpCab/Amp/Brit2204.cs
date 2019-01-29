using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit 2204 amp model.
    /// </summary>
    [DataContract]
    public class Brit2204 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Brit2204()
        {
            DisplayName = ConstAmp.DISP_BRIT_2204;
        }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}
