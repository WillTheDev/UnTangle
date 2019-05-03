using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Jet Flanger Modulation model.
    /// </summary>
    [DataContract]
    public class JetFlanger : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public JetFlanger()
        {
            DisplayName = ConstModulation.DISP_JET_FLANGER;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Manual { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
