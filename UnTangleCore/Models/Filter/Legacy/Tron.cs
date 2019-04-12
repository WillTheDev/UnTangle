using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Tron Filter model.
    /// </summary>
    [DataContract]
    public class Tron : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Tron()
        {
            DisplayName = ConstFilter.DISP_TRON;
            IsLegacy = true;
        }

        [DataMember]
        public int End { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public int Start { get; set; }

        [DataMember]
        public float Speed { get; set; }
        
    };
}
