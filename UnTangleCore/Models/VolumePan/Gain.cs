using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.VolumePan
{
    /// <summary>
    /// Specific settings for the Gain model.
    /// </summary>
    [DataContract]
    public class Gain : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Gain()
        {
            DisplayName = ConstVolPan.DISP_GAIN;
        }
    };
}
