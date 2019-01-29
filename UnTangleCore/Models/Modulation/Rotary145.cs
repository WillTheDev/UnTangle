using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Rotary 145 modulation model.
    /// </summary>
    [DataContract]
    public class Rotary145 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Rotary145()
        {
            DisplayName = ConstModulation.DISP_ROTARY_145;
        }

        [DataMember]
        public float Blend { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float FastSpeed { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float RampTime { get; set; }

        [DataMember]
        public float SlowSpeed { get; set; }

        [DataMember]
        public bool Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int SyncSelect2 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool TempoSync2 { get; set; }
    };
}
