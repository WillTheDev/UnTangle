using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Fassel wah model.
    /// </summary>
    [DataContract]
    public class Fassel : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Fassel()
        {
            DisplayName = ConstWah.DISP_FASSEL;
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
