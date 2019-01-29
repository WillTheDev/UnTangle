using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Wah
{
    /// <summary>
    /// Specific settings for the Throaty wah model.
    /// </summary>
    [DataContract]
    public class Throaty : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Throaty()
        {
            DisplayName = ConstWah.DISP_THROATY;
        }

        [DataMember]
        public float Level { get; set; }
		
        [DataMember]
        public int Pedal { get; set; }
		
        [DataMember]
        public float FcHigh { get; set; }

        [DataMember]
		public int Mix { get; set; }

        [DataMember]
        public float FcLow { get; set; }
		
    };
}
