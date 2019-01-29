using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the UK 846 Wah model.
    /// </summary>
    [DataContract]
    public class UkWah846 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public UkWah846()
        {
            DisplayName = ConstWah.DISP_UK_WAH_846;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Pedal { get; set; }

        [DataMember]
        public float Level { get; set; }

    };
}
