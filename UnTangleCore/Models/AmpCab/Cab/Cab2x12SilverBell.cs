using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 2x12 Silver Bell cabinet model.
    /// </summary>
    [DataContract]
    public class Cab2x12SilverBell : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab2x12SilverBell()
        {
            DisplayName = ConstCab.DISP_2X12_SILVER_BELL;
        }
    };
}
