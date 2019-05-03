using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Dimmension Modulation model.
    /// </summary>
    [DataContract]
    public class Dimmension : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Dimmension()
        {
            DisplayName = ConstModulation.DISP_DIMMENSION;
            IsLegacy = true;
        }

        [DataMember]
        public bool SW1 { get; set; }

        [DataMember]
        public bool SW2 { get; set; }

        [DataMember]
        public bool SW3 { get; set; }

        [DataMember]
        public bool SW4 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

    };
}
