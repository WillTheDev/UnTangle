using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter
{
    /// <summary>
    /// Specific settings for the Mutant Filter model.
    /// </summary>
    [DataContract]
    public class MutantFilter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public MutantFilter()
        {
            DisplayName = ConstFilter.DISP_MUTANT_FILTER;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public bool Range { get; set; }

        [DataMember]
        public int Mode { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Drive { get; set; }

        [DataMember]
        public float Peak { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
