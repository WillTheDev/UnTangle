using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Cali Texas Ch1 amp model.
    /// </summary>
    [DataContract]
    public class CaliTexasCh1 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CaliTexasCh1()
        {
            DisplayName = ConstAmp.DISP_CALI_TEXAS_CH1;
        }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
