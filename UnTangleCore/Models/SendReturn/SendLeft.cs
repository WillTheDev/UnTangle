using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Send Mono Left model.
    /// </summary>
    [DataContract]
    public class SendLeft : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SendLeft()
        {
            DisplayName = ConstSendReturn.DISP_SEND_MONO_1;
        }

        [DataMember]
        public float DryThru { get; set; }

        [DataMember]
        public float Send { get; set; }
			
    };
}
