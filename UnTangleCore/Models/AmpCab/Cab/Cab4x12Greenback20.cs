using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    [DataContract]
    public class Cab4x12Greenback20 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12Greenback20()
        {
            DisplayName = ConstCab.DISP_4X12_GREENBACK_20;
        }

    };
}
