using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the Who Watt 4x14 cab model.
    /// </summary>
    [DataContract]
    public class Cab4x12WhoWatt100 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12WhoWatt100()
        {
            DisplayName = ConstCab.DISP_4X12_WHO_WATT_100;
        }
    };
}
