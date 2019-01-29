using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Cali Rectifire amp model
    /// </summary>
    [DataContract]
    public class CaliRectifire : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CaliRectifire()
        {
            DisplayName = ConstAmp.DISP_CALI_RECTIFIRE;
        }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
