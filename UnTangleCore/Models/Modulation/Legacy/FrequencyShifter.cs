using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Frequency Shifter Modulation model.
    /// </summary>
    [DataContract]
    public class FrequencyShifter : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public FrequencyShifter()
        {
            DisplayName = ConstModulation.DISP_FREQUENCY_SHIFTER;
            IsLegacy = true;
        }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int Mode { get; set; }

        [DataMember]
        public float Speed { get; set; }

    };
}
