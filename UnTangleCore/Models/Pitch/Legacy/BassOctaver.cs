using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Bass Octiver Pitch model.
    /// </summary>
    [DataContract]
    public class BassOctaver : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BassOctaver()
        {
            DisplayName = ConstPitch.DISP_BASS_OCTAVER;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Normal { get; set; }

        [DataMember]
        public float Octave { get; set; }

        [DataMember]
        public float Tone { get; set; }

    };
}
