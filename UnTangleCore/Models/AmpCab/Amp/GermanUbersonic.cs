using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the German Ubersonic model.
    /// </summary>
    [DataContract]
    public class GermanUbersonic : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public GermanUbersonic()
        {
            DisplayName = ConstAmp.DISP_GERMAN_UBERSONIC;
        }

        [DataMember]
		public float ChVol { get; set; }

        [DataMember]
		public float Drive { get; set; }

        [DataMember]
		public float Mid { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
		public float Presence { get; set; }

        [DataMember]
		public float Bass { get; set; }
    };
}
