using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Tri Chorus Modulation model.
    /// </summary>
    [DataContract]
    public class TriChorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TriChorus()
        {
            DisplayName = ConstModulation.DISP_TRI_CHORUS;
            IsLegacy = true;
        }

        [DataMember]
        public float Depth1 { get; set; }

        [DataMember]
        public float Depth2 { get; set; }

        [DataMember]
        public float Depth3 { get; set; }

        [DataMember]
        public float Level { get; set; }

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
