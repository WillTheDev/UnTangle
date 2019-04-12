using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Pitch.Legacy
{
    /// <summary>
    /// Specific settings for the Growler Synth Pitch model.
    /// </summary>
    [DataContract]
    public class Growler : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Growler()
        {
            DisplayName = ConstPitch.DISP_GROWLER;
            IsLegacy = true;
        }

       [DataMember]
        public float Freq { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Pitch { get; set; }

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
