using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Deluxe Comp compressor model.
    /// </summary>
    [DataContract]
    public class DeluxeComp : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DeluxeComp()
        {
            DisplayName = ConstDynamics.DISP_DELUXE_COMP;
        }

        [DataMember]
        public float Threshold { get; set; }

        [DataMember]
        public float Release { get; set; }

        [DataMember]
        public int Knee { get; set; }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Ratio { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
