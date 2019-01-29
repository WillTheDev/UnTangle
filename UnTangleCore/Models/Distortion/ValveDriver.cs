using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion
{
    /// <summary>
    /// Specific settings for the Valve Driver distortion model.
    /// </summary>
    [DataContract]
    public class ValveDriver : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ValveDriver()
        {
            DisplayName = ConstDistortion.DISP_VALVE_DRIVER;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}
