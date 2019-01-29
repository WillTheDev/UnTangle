using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Blue Bell cabinet model.
    /// </summary>
    [DataContract]
    public class Cab1x12BlueBell : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab1x12BlueBell()
        {
            DisplayName = ConstCab.DISP_1X12_BLUE_BELL;
        }
    };
}
