using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the 70s Chrous modulation model.
    /// </summary>
    [DataContract]
    public class Chorus70sChorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Chorus70sChorus()
        {
            DisplayName = ConstModulation.DISP_70S_CHORUS;
        }

        [DataMember]
        public float ChorusIntensity { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int SyncSelect2 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool TempoSync2 { get; set; }

        [DataMember]
        public float VibratoDepth { get; set; }

        [DataMember]
        public float VibratoRate { get; set; }
    };
}
