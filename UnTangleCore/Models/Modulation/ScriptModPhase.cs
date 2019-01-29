using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Modulation
{
    /// <summary>
    /// Specific settings for the Script Mod Phase modulation model.
    /// </summary>
    [DataContract]
    public class ScriptModPhase : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public ScriptModPhase()
        {
            DisplayName = ConstModulation.DISP_SCRIPT_MOD_PHASE;
        }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Level { get; set; }
    };
}
