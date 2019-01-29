using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Multitap 4 delay model.
    /// </summary>
    [DataContract]
    public class Multitap4 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Multitap4()
        {
            DisplayName = ConstDelay.DISP_MULTITAP_4;
        }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int ModulationMode { get; set; }

        [DataMember]
        public float Tap1Delay { get; set; }

        [DataMember]
        public float Tap3Level { get; set; }

        [DataMember]
        public int Time { get; set; }

        [DataMember]
        public float Diffusion { get; set; }

        [DataMember]
        public float Tap4Delay { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public float Tap4Level { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Tap2Level { get; set; }

        [DataMember]
        public int Tap1Pan { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Tap1Level { get; set; }

        [DataMember]
        public float Tap3Delay { get; set; }

        [DataMember]
        public float Tap3Pan { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Tap2Delay { get; set; }

        [DataMember]
        public float Tap2Pan { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public int Tap4Pan { get; set; }
    };
}
