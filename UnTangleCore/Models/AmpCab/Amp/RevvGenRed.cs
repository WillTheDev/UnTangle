using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Revv Gen Red amp model.
    /// </summary>
    [DataContract]
    public class RevvGenRed : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public RevvGenRed()
        {
            DisplayName = ConstAmp.DISP_REVV_GEN_RED;
        }

        [DataMember]
        public int Aggression { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Resonance { get; set; }
    };
}
