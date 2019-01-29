using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the A30 Fawn Nrm amp model.
    /// </summary>
    [DataContract]
    public class A30FawnNrm : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public A30FawnNrm()
        {
            DisplayName = ConstAmp.DISP_A30_FAWN_NRM;
        }

        [DataMember]
        public float Cut { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}
