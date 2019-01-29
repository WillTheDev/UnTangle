using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 4x12 Mandarin EM cab model.
    /// </summary>
    [DataContract]
    public class Cab4x12MandarinEM : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab4x12MandarinEM()
        {
            DisplayName = ConstCab.MODEL_4X12_MANDARIN_EM;
        }
    };
}
