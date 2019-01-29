using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Sweel Vintage Digital delay model.
    /// </summary>
    [DataContract]
    public class SwellVintageDigital : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SwellVintageDigital()
        {
            DisplayName = ConstDelay.DISP_SWELL_VINTAGE_DIGITAL;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int BitDepth { get; set; }

        [DataMember]
        public int SampleRate { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
        public float Threshold { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
