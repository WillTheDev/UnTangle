using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the US Small Tweed amp model.
    /// </summary>
    [DataContract]
    public class USSmallTweed : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public USSmallTweed()
        {
            DisplayName = ConstAmp.DISP_US_SMALL_TWEED;
        }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
