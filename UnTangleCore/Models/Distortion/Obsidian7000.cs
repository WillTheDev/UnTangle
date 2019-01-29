using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Sepcific settings for the Obsidian distortion model.
    /// </summary>
    [DataContract]
    public class Obsidian7000 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Obsidian7000()
        {
            DisplayName = ConstDistortion.DISP_OBSIDIAN_7000;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float HiMid { get; set; }

        [DataMember]
        public float LoMid { get; set; }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float HiMidFreq { get; set; }

        [DataMember]
        public float LoMidFreq { get; set; }

        [DataMember]
        public float Grunt { get; set; }

        [DataMember]
        public bool Distortion { get; set; }

        [DataMember]
        public float Blend { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
