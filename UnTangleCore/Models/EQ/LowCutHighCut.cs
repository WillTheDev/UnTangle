using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Low cut high cut model.
    /// </summary>
    [DataContract]
    public class LowCutHighCut : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public LowCutHighCut()
        {
            DisplayName = ConstEQ.DISP_LOW_CUT_HIGH_CUT;
        }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

    };
}
