using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Bias Tremolo model.
    /// </summary>
    [DataContract]
    public class BiasTremolo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BiasTremolo()
        {
            DisplayName = ConstModulation.DISP_BIAS_TREMOLO;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Shape { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Volsens { get; set; }
    };
}
