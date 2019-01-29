using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Cartographer amplifier model.
    /// </summary>
    [DataContract]
    public class Cartographer : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cartographer()
        {
            DisplayName = ConstAmp.DISP_CARTOGRAPHER;
        }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public bool Bright1 { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Drive2 { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public bool Bright2 { get; set; }
    };
}
