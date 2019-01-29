using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 2x12 Double C12N cab model.
    /// </summary>
    [DataContract]
    public class Cab2x12DoubleC12N : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab2x12DoubleC12N()
        {
            DisplayName = ConstCab.DISP_2X12_DOUBLE_C12N;
        }
    };
}
