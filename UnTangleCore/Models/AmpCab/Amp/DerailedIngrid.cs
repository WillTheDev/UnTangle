using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Derailed Ingrid amp model.
    /// </summary>
    [DataContract]
    public class DerailedIngrid : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DerailedIngrid()
        {
            DisplayName = ConstAmp.DISP_DERAILED_INGRID;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Bright { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
