using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Send Stereo model.
    /// </summary>
    [DataContract]
    public class SendStereoLR : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SendStereoLR()
        {
            DisplayName = ConstSendReturn.DISP_SEND_STEREO_1_2;
        }

        [DataMember]
        public float DryThru { get; set; }

        [DataMember]
        public float Send { get; set; }
			
    };
}
