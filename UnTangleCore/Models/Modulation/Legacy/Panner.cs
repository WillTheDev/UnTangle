using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation.Legacy
{
    /// <summary>
    /// Specific settings for the Panner tremolo model.
    /// </summary>
    [DataContract]
    public class Panner : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Panner()
        {
            DisplayName = ConstModulation.DISP_PANNER;
            IsLegacy = true;
        }

        [DataMember]
        public int Depth { get; set; }
        
        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Shape { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float VolSen { get; set; }
    };
    
}
