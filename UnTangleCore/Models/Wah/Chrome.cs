using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Chrome Wah model.
    /// </summary>
    [DataContract]
    public class Chrome : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Chrome()
        {
            DisplayName = ConstWah.DISP_CHROME;
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
