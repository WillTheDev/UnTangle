using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 2x12 mail C12Q cab model.
    /// </summary>
    [DataContract]
    public class Cab2x12MailC12Q : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab2x12MailC12Q()
        {
            DisplayName = ConstCab.DISP_2X12_MAIL_C12Q;
        }
    };
}
