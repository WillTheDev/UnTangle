using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    [DataContract]
    public class LASutdioComp : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public LASutdioComp()
        {
            DisplayName = ConstDynamics.DISP_LA_STUDIO_COMP;
        }

        [DataMember]
        public float Emphasis { get; set; }

        [DataMember]
        public int Mix { get; set; }

        [DataMember]
        public float PeakReduction { get; set; }

        [DataMember]
        public new bool Type { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Gain { get; set; }
    };
}
