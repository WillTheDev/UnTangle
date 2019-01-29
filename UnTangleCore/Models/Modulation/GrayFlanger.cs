using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Gray Flanger modulation model.
    /// </summary>
    [DataContract]
    public class GrayFlanger : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public GrayFlanger()
        {
            DisplayName = ConstModulation.DISP_GRAY_FLANGER;
        }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Manual { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Width { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Regen { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Rate { get; set; }
    };
}
