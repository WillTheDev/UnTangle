using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Parametric EQ model.
    /// </summary>
    [DataContract]
    public class Parametric : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Parametric()
        {
            DisplayName = ConstEQ.DISP_PARAMETRIC;
        }

        [DataMember]
        public float MidGain { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float HighQ { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float HighFreq { get; set; }

        [DataMember]
        public float MidQ { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float LowGain { get; set; }

        [DataMember]
        public float LowFreq { get; set; }

        [DataMember]
        public float LowQ { get; set; }

        [DataMember]
        public float MidFreq { get; set; }

        [DataMember]
        public float HighGain { get; set; }
    };
}
