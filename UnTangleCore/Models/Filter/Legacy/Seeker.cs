using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Seeker Filter model.
    /// </summary>
    [DataContract]
    public class Seeker : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Seeker()
        {
            DisplayName = ConstFilter.DISP_SEEKER;
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
        public int Steps { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
