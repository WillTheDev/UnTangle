using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Celest 12H cab model.
    /// </summary>
    [DataContract]
    public class Cab1x12Celest12H : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab1x12Celest12H()
        {
            DisplayName = ConstCab.DISP_1X12_CELEST_12H;
        }
    };
}
