using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.VolumePan
{
    /// <summary>
    /// Specific settings for the Volume model.
    /// </summary>
    [DataContract]
    public class Volume : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Volume()
        {
            DisplayName = ConstVolPan.DISP_VOLUME;
        }

        [DataMember]
        public bool VolumeTaper { get; set; }

        [DataMember]
		public float Pedal { get; set; }
    };
}
