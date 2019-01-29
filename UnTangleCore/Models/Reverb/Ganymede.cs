using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb
{
    /// <summary>
    /// Specific settings for the Ganymede reverb model.
    /// </summary>
    [DataContract]
    public class Ganymede : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Ganymede()
        {
            DisplayName = ConstReverb.DISP_GANYMEDE;
        }

        [DataMember]
        public float Modulation { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public float Predelay { get; set; }
    };
}
