using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.FxLoop
{
    /// <summary>
    /// Specific settings for the FX Loop Right model.
    /// </summary>
    [DataContract]
    public class FXLoopRight : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FXLoopRight()
        {
            DisplayName = ConstFxLoop.DISP_FX_LOOP_MONO_2;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Send { get; set; }

        [DataMember]
        public float Return { get; set; }
				
    };
}
