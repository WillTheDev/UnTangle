using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the Soup Pro Ellipse cabinet model.
    /// </summary>
    [DataContract]
    public class Cab1x6x9SoupProEllipse : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab1x6x9SoupProEllipse()
        {
            DisplayName = ConstCab.DISP_1X6X9_SOUP_PRO_ELLIPSE;
        }
    };
}
