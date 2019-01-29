using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Weeper wah model.
    /// </summary>
    [DataContract]
    public class Weeper : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Weeper()
        {
            DisplayName = ConstWah.DISP_WEEPER;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float FcHigh { get; set; }

        [DataMember]
        public float Pedal { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float FcLow { get; set; }
    };
}
