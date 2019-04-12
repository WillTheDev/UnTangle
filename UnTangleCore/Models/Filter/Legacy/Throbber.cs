using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Throbber Filter model.
    /// </summary>
    [DataContract]
    public class Throbber : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Throbber()
        {
            DisplayName = ConstFilter.DISP_THROBBER;
            IsLegacy = true;
        }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int Wave { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
