using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 1960 T75 cabinet model.
    /// </summary>
    [DataContract]
    public class Cab4x121960T75 : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x121960T75()
        {
            DisplayName = ConstCab.DISP_4X12_1960_T75;
        }
    };
}
