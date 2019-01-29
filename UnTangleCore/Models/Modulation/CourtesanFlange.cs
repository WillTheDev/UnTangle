using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Gray Courtesan Flange modulation model.
    /// </summary>
    [DataContract]
    public class CourtesanFlange : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CourtesanFlange()
        {
            DisplayName = ConstModulation.DISP_COURTESAN_FLANGE;
        }

        [DataMember]
        public float Color { get; set; }

        [DataMember]
        public bool FilterMatrix { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Range { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
