using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab.Bass
{
    /// <summary>
    /// Specific settings for the 6x10 Cali Power bass cabinet model.
    /// </summary>
    [DataContract]
    public class Cab6x10CaliPower : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab6x10CaliPower()
        {
            DisplayName = ConstCab.DISP_6X10_CALI_POWER;
        }
    };
}
