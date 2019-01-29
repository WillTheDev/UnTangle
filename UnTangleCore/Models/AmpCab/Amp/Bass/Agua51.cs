using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp.Bass
{
    /// <summary>
    /// Specific settings for the Agua 51 bass amp model.
    /// </summary>
    [DataContract]
    public class Agua51 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Agua51()
        {
            DisplayName = ConstAmp.DISP_AGUA_51;
        }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public bool Bright { get; set; }

        [DataMember]
        public bool Deep { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Ch Vol")]
        public float Ch_Vol { get; set; }
        
        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}
