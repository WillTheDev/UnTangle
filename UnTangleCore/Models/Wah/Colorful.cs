using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Colorful Wah model.
    /// </summary>
    [DataContract]
    public class Colorful : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Colorful()
        {
            DisplayName = ConstWah.DISP_COLORFUL;
        }

        [DataMember]
        public float Pedal { get; set; }

        [DataMember]
        public float FcLow { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float FcHigh { get; set; }

    };
}
