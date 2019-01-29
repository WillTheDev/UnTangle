using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 Solo Lead cabinet model.
    /// </summary>
    [DataContract]
    public class Cab4x12SoloLeadEM : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12SoloLeadEM()
        {
            DisplayName = ConstCab.DISP_4X12_SOLO_LEAD_EM;
        }
    };
}
