using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Return Mono Right model.
    /// </summary>
    [DataContract]
    public class ReturnRight : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ReturnRight()
        {
            DisplayName = ConstSendReturn.DISP_RETURN_MONO_2;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Return { get; set; }
			
    };
}
