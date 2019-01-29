using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Field Coil cab model.
    /// </summary>
    [DataContract]
    public class Cab1x12FieldCoil : CabBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Cab1x12FieldCoil()
        {
            DisplayName = ConstCab.DISP_1X12_FIELD_COIL;
        }
    };
}
