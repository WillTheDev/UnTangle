using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Kinky Comp compressor model.
    /// </summary>
    [DataContract]
    public class KinkyComp : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public KinkyComp()
        {
            DisplayName = ConstDynamics.DISP_KINKY_COMP;
        }

        [DataMember]
        public float Attack { get; set; }

        [DataMember]
        public float Release { get; set; }
               
        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Sensitivity { get; set; }

        [DataMember]
        public float Level { get; set; }

    };
}
