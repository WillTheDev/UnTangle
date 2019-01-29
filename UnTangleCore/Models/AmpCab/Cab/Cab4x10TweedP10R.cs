using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x10 Tweed P10R cab model.
    /// </summary>
    [DataContract]
    public class Cab4x10TweedP10R : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x10TweedP10R()
        {
            DisplayName = ConstCab.DISP_4X10_TWEED_P10R;
        }
    };
}
