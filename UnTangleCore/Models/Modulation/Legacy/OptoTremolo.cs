using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Opto Tremolo model.
    /// </summary>
    [DataContract]
    public class OptoTremolo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public OptoTremolo()
        {
            DisplayName = ConstModulation.DISP_OPTO_TREMOLO;
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
