using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Mod Chorus Echo delay model.
    /// </summary>
    [DataContract]
    public class ModChorusEcho : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ModChorusEcho()
        {
            DisplayName = ConstDelay.DISP_MOD_CHORUS_ECHO;
        }

        [DataMember]
        public float Depth { get; set; }

        [DataMember]
        public float Speed { get; set; }

        [DataMember]
        public int SyncSelect1  { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public int ModulationMode { get; set; }

        [DataMember]
        public float Scale { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}
