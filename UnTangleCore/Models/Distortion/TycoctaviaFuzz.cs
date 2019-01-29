using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Tycotavia Fuzz distortion model.
    /// </summary>
    [DataContract]
    public class TycoctaviaFuzz : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TycoctaviaFuzz()
        {
            DisplayName = ConstDistortion.DISP_TYCOCTAVIA_FUZZ;
        }

        [DataMember]
        public float Fuzz { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
