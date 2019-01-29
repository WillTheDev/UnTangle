using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Model specific settings.
    /// </summary>
    [DataContract]
    public class GermanMahadeva : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public GermanMahadeva()
        {
            DisplayName = ConstAmp.DISP_GERMAN_MAHADEVA;
        }
        
        [DataMember]
        public float Drive { get; set; }
        
        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float ChVol { get; set; }
        
        [DataMember]
        public float Bass { get; set; }
        
        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

    };
}
