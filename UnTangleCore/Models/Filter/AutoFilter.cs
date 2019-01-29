using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter
{
    /// <summary>
    /// Specific settings for the Auto Filter model.
    /// </summary>
    [DataContract]
    public class AutoFilter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AutoFilter()
        {
            DisplayName = ConstFilter.DISP_AUTO_FILTER;
        }

        [DataMember]
        public float FreqDepth { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Sens { get; set; }

        [DataMember]
        public float FilterGain { get; set; }

        [DataMember]
        public float FilterQ { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Direction { get; set; }

        [DataMember]
        public float Frequency { get; set; }

        [DataMember]
        public int Mode { get; set; }
    };
}
