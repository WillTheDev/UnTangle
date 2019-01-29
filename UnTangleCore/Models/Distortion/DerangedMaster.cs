using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Deranged Master distortion model.
    /// </summary>
    [DataContract]
    public class DerangedMaster : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DerangedMaster()
        {
            DisplayName = ConstDistortion.DISP_DERANGED_MASTER;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
