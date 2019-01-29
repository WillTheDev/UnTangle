using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.FxLoop
{
    /// <summary>
    /// Specific settings for the FX Loop Mono model.
    /// </summary>
    [DataContract]
    public class FXLoopLeft : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FXLoopLeft()
        {
            DisplayName = ConstFxLoop.DISP_FX_LOOP_MONO_1;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Send { get; set; }

        [DataMember]
        public float Return { get; set; }
				
    };
}
