using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Deluxe Phaser modulation model.
    /// </summary>
    [DataContract]
    public class DeluxePhaser : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public DeluxePhaser()
        {
            DisplayName = ConstModulation.DISP_DELUXE_PHASER;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Offset { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int Stages { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int WaveShape { get; set; }
    };
}
