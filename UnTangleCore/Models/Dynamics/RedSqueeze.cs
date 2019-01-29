using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Dynamics
{
    /// <summary>
    /// Specific settings for the Red Squeeze compressor model.
    /// </summary>
    [DataContract]
    public class RedSqueeze : Block
    {
        public RedSqueeze()
        {
            DisplayName = ConstDynamics.DISP_RED_SQUEEZE;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Sensitivity { get; set; }
    };
}
