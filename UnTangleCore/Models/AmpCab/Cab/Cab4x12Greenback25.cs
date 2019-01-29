using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 Greenback 25 cab model.
    /// </summary>
    [DataContract]
    public class Cab4x12Greenback25 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12Greenback25()
        {
            DisplayName = ConstCab.DISP_4X12_GREENBACK_25;
        }
    };
}
