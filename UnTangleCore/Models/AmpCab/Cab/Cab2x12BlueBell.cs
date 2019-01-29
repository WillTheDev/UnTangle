using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 2x12 Blue Bell cab model.
    /// </summary>
    [DataContract]
    public class Cab2x12BlueBell : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab2x12BlueBell()
        {
            DisplayName = ConstCab.DISP_2X12_BLUE_BELL;
        }
    };
}
