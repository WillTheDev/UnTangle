using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Delay.Legacy
{
    /// <summary>
    /// Specific settings for the Legacy Tape Echo Stereo Delay delay model.
    /// </summary>
    [DataContract]
    public class TapeEchoStereo : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TapeEchoStereo()
        {
            DisplayName = ConstDelay.DISP_TAPE_ECHO_STEREO;
            IsLegacy = true;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public bool DryThru { get; set; }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool Time { get; set; }

        [DataMember]
        public float Treble { get; set; }

    };
}
