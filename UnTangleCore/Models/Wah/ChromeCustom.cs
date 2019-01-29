using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Chrome Custom Wah model.
    /// </summary>
    [DataContract]
    public class ChromeCustom : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ChromeCustom()
        {
            DisplayName = ConstWah.DISP_CHROME_CUSTOM;
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
