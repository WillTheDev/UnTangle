using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the 80A Flanger Modulation model.
    /// </summary>
    [DataContract]
    public class ADAFlanger : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ADAFlanger()
        {
            DisplayName = ConstModulation.DISP_80A_FLANGER;
            IsLegacy = true;
        }

        [DataMember]
        public float Enhance { get; set; }

        [DataMember]
        public bool Harmonic { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Manual { get; set; }

        [DataMember]
        public float Range { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
