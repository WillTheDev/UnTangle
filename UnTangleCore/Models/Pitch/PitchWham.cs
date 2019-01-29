using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch
{
    /// <summary>
    /// Specific settings for the Pitch Wham pitch model.
    /// </summary>
    [DataContract]
    public class PitchWham : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PitchWham()
        {
            DisplayName = ConstPitch.DISP_PITCH_WHAM;
        }

        [DataMember]
        public float Pedal { get; set; }

        [DataMember]
        public float Heel { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Toe { get; set; }

        [DataMember]
        public float Mix { get; set; }
    };
}
