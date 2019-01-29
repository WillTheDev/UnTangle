using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Room reverb model.
    /// </summary>
    [DataContract]
    public class Room : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Room()
        {
            DisplayName = ConstReverb.DISP_ROOM;
        }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Predelay { get; set; }
    };
}
