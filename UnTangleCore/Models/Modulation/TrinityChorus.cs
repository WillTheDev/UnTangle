using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Trinity Chorus modulation model.
    /// </summary>
    [DataContract]
    public class TrinityChorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TrinityChorus()
        {
            DisplayName = ConstModulation.DISP_TRINITY_CHORUS;
        }

        [DataMember]
        public bool CenterBoost { get; set; }

        [DataMember]
        public bool RightBoost { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Right { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Left { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Center { get; set; }

        [DataMember]
        public bool LeftBoost { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Manual { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public bool Preset { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
