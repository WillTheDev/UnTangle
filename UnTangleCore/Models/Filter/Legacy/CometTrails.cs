using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter.Legacy
{
    /// <summary>
    /// Specific settings for the Comet Trails Filter model.
    /// </summary>
    [DataContract]
    public class CometTrails : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CometTrails()
        {
            DisplayName = ConstFilter.DISP_COMET_TRAILS;
            IsLegacy = true;
        }

        [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Gain { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Q { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
        
    };
}
