using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Echo Platter delay model.
    /// </summary>
    [DataContract]
    public class EchoPlatter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public EchoPlatter()
        {
            DisplayName = ConstDelay.DISP_ECHO_PLATTER;
            IsLegacy = true;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public bool DryThru { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
        
        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "Wow Flt")]
        public float WowFlt { get; set; }
    };
}
