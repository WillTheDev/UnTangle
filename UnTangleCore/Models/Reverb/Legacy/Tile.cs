using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb.Legacy
{
    /// <summary>
    /// Specific settings for the Tile reverb model.
    /// </summary>
    [DataContract]
    public class Tile : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Tile()
        {
            DisplayName = ConstReverb.DISP_TILE;
            IsLegacy = true;
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
