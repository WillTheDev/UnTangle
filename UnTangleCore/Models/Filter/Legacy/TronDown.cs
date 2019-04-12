using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Tron Down Filter model.
    /// </summary>
    [DataContract]
    public class TronDown : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TronDown()
        {
            DisplayName = ConstFilter.DISP_TRON_DOWN;
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
        public bool Range { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Type")]
        public int QType { get; set; }
        
    };
}
