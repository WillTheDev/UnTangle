using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Lead 80 cabinet model.
    /// </summary>
    [DataContract]
    public class Cab1x12Lead80 : CabBase
    {
        public Cab1x12Lead80()
        {
            DisplayName = ConstCab.DISP_1X12_LEAD_80;
        }

    };
}
