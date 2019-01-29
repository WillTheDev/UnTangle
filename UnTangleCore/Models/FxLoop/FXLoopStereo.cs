using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.FxLoop
{
    /// <summary>
    /// Specific settings for the FX Loop Stereo model.
    /// </summary>
    [DataContract]
    public class FXLoopStereo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FXLoopStereo()
        {
            DisplayName = ConstFxLoop.DISP_FX_LOOP_STEREO;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Send { get; set; }

        [DataMember]
        public float Return { get; set; }
				
    };
}
