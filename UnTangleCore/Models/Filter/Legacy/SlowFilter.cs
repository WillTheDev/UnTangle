using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Slow Filter Filter model.
    /// </summary>
    [DataContract]
    public class SlowFilter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SlowFilter()
        {
            DisplayName = ConstFilter.DISP_SLOW_FILTER;
            IsLegacy = true;
        }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        public float Speed { get; set; }
        
    };
}
