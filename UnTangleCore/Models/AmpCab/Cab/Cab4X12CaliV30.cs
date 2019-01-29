using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 Cali V30 cab model.
    /// </summary>
    [DataContract]
    public class Cab4X12CaliV30 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4X12CaliV30()
        {
            DisplayName = ConstCab.DISP_4X12_CALI_V30;
        }
    };
}
