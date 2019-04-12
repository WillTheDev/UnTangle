using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Obi Wah Filter model.
    /// </summary>
    [DataContract]
    public class ObiWah : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ObiWah()
        {
            DisplayName = ConstFilter.DISP_OBI_WAH;
            IsLegacy = true;
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
        [JsonProperty(PropertyName = "Type")]
        public int QType { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
