using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Return Mono Left model.
    /// </summary>
    [DataContract]
    public class ReturnLeft : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ReturnLeft()
        {
            DisplayName = ConstSendReturn.DISP_RETURN_MONO_1;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Return { get; set; }
			
    };
}
