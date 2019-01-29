using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the 60s Bias Tremolo model.
    /// </summary>
    [DataContract]
    public class Mod60sBiasTrem : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Mod60sBiasTrem()
        {
            DisplayName = ConstModulation.DISP_60S_BIAS_TREM;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public float Spread { get; set; }
    };
}
