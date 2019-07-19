using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.EQ
{
    /// <summary>
    /// Specific settings for the Simple Tilt EQ model.
    /// </summary>
    [DataContract]
    public class SimpleTilt : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name,
        /// </summary>
        public SimpleTilt()
        {
            DisplayName = ConstEQ.DISP_SIMPLE_TILT;
        }

        [DataMember]
        public float CenterFreq { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
		public float Tilt { get; set; }
    };
}
