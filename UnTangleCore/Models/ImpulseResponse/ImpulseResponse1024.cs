using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.ImpulseResponse
{
    /// <summary>
    /// Specific settings for the Impulse Response 1024 block.
    /// </summary>
    [DataContract]
    public class ImpulseResponse1024 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ImpulseResponse1024()
        {
            DisplayName = ConstIR.DISP_IMPULSE_RESPONSE_1024;
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
    };
}
