using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Simple 3 Band EQ model.
    /// </summary>
    [DataContract]
    public class Simple3Band : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name,
        /// </summary>
        public Simple3Band()
        {
            DisplayName = ConstEQ.DISP_SIMPLE_3_BAND;
        }

        [DataMember]
        public float LowGain { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
		public float MidFreq { get; set; }

        [DataMember]
		public float MidGain { get; set; }

        [DataMember]
		public float HighGain { get; set; }
    };
}
