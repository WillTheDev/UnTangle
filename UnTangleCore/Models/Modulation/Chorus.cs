using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Chrous modulation model.
    /// </summary>
    [DataContract]
    public class Chorus : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Chorus()
        {
            DisplayName = ConstModulation.DISP_CHORUS;
        }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int WaveShape { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Predelay { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }
    };
}
