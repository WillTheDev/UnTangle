using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 Blackback 30 cabinet model.
    /// </summary>
    [DataContract]
    public class Cab4x12Blackback30 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12Blackback30()
        {
            DisplayName = ConstCab.DISP_4X12_BLACKBACK_30;
        }
    };
}
