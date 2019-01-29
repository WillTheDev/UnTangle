using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Transistor Tape delay model.
    /// </summary>
    [DataContract]
    public class TransistorTape : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TransistorTape()
        {
            DisplayName = ConstDelay.DISP_TRANSISTOR_TAPE;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int Headroom { get; set; }

        [DataMember]
        public float WowFlutter { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public int Scale { get; set; }

        [DataMember]
        public float Time { get; set; }

        [DataMember]
		public bool TempoSync1 { get; set; }
    };
}
