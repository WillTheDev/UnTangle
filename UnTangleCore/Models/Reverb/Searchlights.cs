using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb
{
    /// <summary>
    /// Specific settings for the Searchlights reverb model.
    /// </summary>
    [DataContract]
    public class Searchlights : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Searchlights()
        {
            DisplayName = ConstReverb.DISP_SEARCHLIGHTS;
        }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Modulation { get; set; }

        [DataMember]
        public float Predelay { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Spread { get; set; }
    };
}
