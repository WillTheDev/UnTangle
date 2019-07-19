using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Low shelf high shelf model.
    /// </summary>
    [DataContract]
    public class LowShelfHighShelf : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public LowShelfHighShelf()
        {
            DisplayName = ConstEQ.DISP_LOW_SHELF_HIGH_SHELF;
        }

        [DataMember]
        public float HighFreq { get; set; }

        [DataMember]
        public float HighGain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowFreq { get; set; }

        [DataMember]
        public float LowGain { get; set; }

    };
}
