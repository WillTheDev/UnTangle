using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Q-Filter Filter model.
    /// </summary>
    [DataContract]
    public class QFilter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public QFilter()
        {
            DisplayName = ConstFilter.DISP_Q_FILTER;
            IsLegacy = true;
        }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Type")]
        public int QType { get; set; }
        
    };
}
