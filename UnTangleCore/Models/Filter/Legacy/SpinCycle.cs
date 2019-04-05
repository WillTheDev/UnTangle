using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Spin Cycle Filter model.
    /// </summary>
    [DataContract]
    public class SpinCycle : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SpinCycle()
        {
            DisplayName = ConstFilter.DISP_SPIN_CYCLE;
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
        [JsonProperty(PropertyName = "Vol Sens")]
        public float VolSens { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
