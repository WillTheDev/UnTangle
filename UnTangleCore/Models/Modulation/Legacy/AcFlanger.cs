using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the AC Flanger Modulation model.
    /// </summary>
    [DataContract]
    public class ACFlanger : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ACFlanger()
        {
            DisplayName = ConstModulation.DISP_AC_FLANGER;
            IsLegacy = true;
        }

        [DataMember]
        public float Regen { get; set; }

        [DataMember]
        public float Width { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Manual { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
