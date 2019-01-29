using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Ubiquitous Vibe modulation model.
    /// </summary>
    [DataContract]
    public class UbiquitousVibe : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public UbiquitousVibe()
        {
            DisplayName = ConstModulation.DISP_UBIQUITOUS_VIBE;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float LampBias { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Mode { get; set; }
    };
}
