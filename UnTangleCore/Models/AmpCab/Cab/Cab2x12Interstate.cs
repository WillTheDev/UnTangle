using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 2x12 Interstate cab model.
    /// </summary>
    [DataContract]
    public class Cab2x12Interstate : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab2x12Interstate()
        {
            DisplayName = ConstCab.DISP_2X12_INTERSTATE;
        }
    };
}
