using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Placater Clean amplifier model.
    /// </summary>
    [DataContract]
    public class PlacaterClean : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PlacaterClean()
        {
            DisplayName = ConstAmp.DISP_PLACATER_CLEAN;
        }

        [DataMember]
        public float Bright { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
