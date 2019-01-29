using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Placater Dirty amp model.
    /// </summary>
    [DataContract]
    public class PlacaterDirty : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PlacaterDirty()
        {
            DisplayName = ConstAmp.DISP_PLACATER_DIRTY;
        }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public bool Saturation { get; set; }

        [DataMember]
        public bool C45 { get; set; }

        [DataMember]
        public bool Voice { get; set; }

        [DataMember]
        public int SSwitch { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public bool HBE { get; set; }

        [DataMember]
        public bool Fat { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
