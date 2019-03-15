using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Jet Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class JetFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public JetFuzz()
        {
            DisplayName = ConstDistortion.DISP_JET_FUZZ;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public float Rate { get; set; }
    };
}
