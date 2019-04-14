using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation.Legacy
{
    /// <summary>
    /// Specific settings for the Pattern Trem tremolo model.
    /// </summary>
    [DataContract]
    public class PatternTrem : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PatternTrem()
        {
            DisplayName = ConstModulation.DISP_PATTERN_TREM;
            IsLegacy = true;
        }

        [DataMember]
        public int Step1 { get; set; }

        [DataMember]
        public int Step2 { get; set; }

        [DataMember]
        public int Step3 { get; set; }

        [DataMember]
        public int Step4 { get; set; }
        
        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
    };
}
