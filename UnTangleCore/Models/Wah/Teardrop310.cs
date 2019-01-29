using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Teardrop 310 Wah model.
    /// </summary>
    [DataContract]
    public class Teardrop310 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Teardrop310()
        {
            DisplayName = ConstWah.DISP_TEARDROP_310;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Pedal { get; set; }

        [DataMember]
        public float Level { get; set; }

    };
}
