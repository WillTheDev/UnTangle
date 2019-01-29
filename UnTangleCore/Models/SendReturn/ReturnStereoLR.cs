using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Return Stereo model.
    /// </summary>
    [DataContract]
    public class ReturnStereoLR : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ReturnStereoLR()
        {
            DisplayName = ConstSendReturn.DISP_RETURN_STEREO_1_2;
        }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Return { get; set; }
			
    };
}
