using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Heir Apparent distortion model.
    /// </summary>
    [DataContract]
    public class HeirApparent : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public HeirApparent()
        {
            DisplayName = ConstDistortion.DISP_HEIR_APPARENT;
        }

        [DataMember]
        public int Clipping { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public int GainMod { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public bool Voltage { get; set; }
    };
}
