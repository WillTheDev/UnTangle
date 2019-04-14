using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Script Phase tremolo model.
    /// </summary>
    [DataContract]
    public class ScriptPhase : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ScriptPhase()
        {
            DisplayName = ConstModulation.DISP_SCRIPT_PHASE;
            IsLegacy = true;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float Speed { get; set; }

    };
}
