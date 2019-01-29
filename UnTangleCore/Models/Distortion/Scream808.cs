using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    [DataContract]
    public class Scream808 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Scream808()
        {
            DisplayName = ConstDistortion.DISP_SCREAM_808;
        }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
