using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Bucket Brigade delay model.
    /// </summary>
    [DataContract]
    public class BucketBrigade : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BucketBrigade()
        {
            DisplayName = ConstDelay.DISP_BUCKET_BRIGADE;
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
    };
}
