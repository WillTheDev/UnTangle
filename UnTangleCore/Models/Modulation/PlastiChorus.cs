using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Plasti Chrous modulation model.
    /// </summary>
    [DataContract]
    public class PlastiChorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public PlastiChorus()
        {
            DisplayName = ConstModulation.DISP_PLASTI_CHORUS;
        }
        
        [DataMember]
        public int WaveShape { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Headroom { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public bool Mode { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Spread { get; set; }
        
        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Tone { get; set; }
    };
}
