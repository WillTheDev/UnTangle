using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter
{
    /// <summary>
    /// Specific settings for the Mystery Filter model.
    /// </summary>
    [DataContract]
    public class MysteryFilter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MysteryFilter()
        {
            DisplayName = ConstFilter.DISP_MYSTERY_FILTER;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Frequency { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Release { get; set; }

        [DataMember]
        public float Resonance { get; set; }

        [DataMember]
        public float Sensitivity { get; set; }
    };
}
