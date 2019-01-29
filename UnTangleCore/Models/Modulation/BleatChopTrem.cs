using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Bleat Chop tremolo model.
    /// </summary>
    [DataContract]
    public class BleatChopTrem : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BleatChopTrem()
        {
            DisplayName = ConstModulation.DISP_BLEAT_CHOP_TREM;
        }

        [DataMember]
        public int Step3 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public int WaveShape { get; set; }

        [DataMember]
        public int Step1 { get; set; }

        [DataMember]
        public int Step4 { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int Step2 { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Depth { get; set; }
    };
}
