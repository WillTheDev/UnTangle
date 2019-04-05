using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Voice Box Filter model.
    /// </summary>
    [DataContract]
    public class VoiceBox : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public VoiceBox()
        {
            DisplayName = ConstFilter.DISP_VOICE_BOX;
        }

        [DataMember]
        public int Auto { get; set; }

        [DataMember]
        public int End { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int Start { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
