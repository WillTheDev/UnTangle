using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab.Bass
{
    /// <summary>
    /// Specific settings for the 8x10 SV Beast cab model.
    /// </summary>
    [DataContract]
    public class Cab8x10SVBeast : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab8x10SVBeast()
        {
            DisplayName = ConstCab.DISP_8X10_SV_BEAST;
        }
    };
}
