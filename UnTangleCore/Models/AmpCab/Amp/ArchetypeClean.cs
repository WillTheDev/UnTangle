using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Archetype Clean amp model.
    /// </summary>
    [DataContract]
    public class ArchetypeClean : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ArchetypeClean()
        {
            DisplayName = ConstAmp.DISP_ARCHETYPE_CLEAN;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public bool BrightSW { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Depth { get; set; }

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
