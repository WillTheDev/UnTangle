using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Elephant Man delay model.
    /// </summary>
    [DataContract]
    public class ElephantMan : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ElephantMan()
        {
            DisplayName = ConstDelay.DISP_ELEPHANT_MAN;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int Scale { get; set; }
        
        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Noise { get; set; }

        [DataMember]
        public float Time { get; set; }

        [DataMember]
        public float Level { get; set; }
        
        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Depth { get; set; }
    };
}
