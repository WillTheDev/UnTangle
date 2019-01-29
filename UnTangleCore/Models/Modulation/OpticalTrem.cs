using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Optical Tremolo model.
    /// </summary>
    [DataContract]
    public class OpticalTrem : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public OpticalTrem()
        {
            DisplayName = ConstModulation.DISP_OPTICAL_TREM;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Intensity { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }
    };
}
