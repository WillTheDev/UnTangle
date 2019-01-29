using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specifc settings for the 1x12 US Deluxe cab model.
    /// </summary>
    [DataContract]
    public class Cab1x12USDeluxe : CabBase
    {
        public Cab1x12USDeluxe()
        {
            DisplayName = ConstCab.DISP_1X12_US_DELUXE;
        }
    };
}
