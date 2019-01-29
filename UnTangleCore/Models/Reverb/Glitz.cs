using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb
{
    /// <summary>
    /// Specific settings for the Glitz reverb model.
    /// </summary>
    [DataContract]
    public class Glitz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Glitz()
        {
            DisplayName = ConstReverb.DISP_GLITZ;
        }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Mod Mix")]
		public float ModMix { get; set; }

        [DataMember]
		public float HighCut { get; set; }

        [DataMember]
		public float LowCut { get; set; }

        [DataMember]
		public float Level { get; set; }

        [DataMember]
        public float Delay { get; set; }

        [DataMember]
		public float Decay { get; set; }

        [DataMember]
		public float Depth { get; set; }

        [DataMember]
		public bool TempoSync1 { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Predelay { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Xover { get; set; }
    };
}
