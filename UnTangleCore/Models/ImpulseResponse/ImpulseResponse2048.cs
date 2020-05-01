using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.ImpulseResponse
{
    /// <summary>
    /// Specific settings for the Impulse Response 2048 block.
    /// </summary>
    [DataContract]
    public class ImpulseResponse2048 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ImpulseResponse2048()
        {
            DisplayName = ConstIR.DISP_IMPULSE_RESPONSE_2048;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int Index { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public int Mix { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember(Name = "@uuid")]
        public string uuid { get; set; }
    };
}
