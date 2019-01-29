﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit Plexi Jump amplifier model.
    /// </summary>
    [DataContract]
    public class BritPlexiJump : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BritPlexiJump()
        {
            DisplayName = ConstAmp.DISP_BRIT_PLEXI_JUMP;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float BrtDrive { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float NrmDrive { get; set; }

        [DataMember]
        public float ChVol { get; set; }
    };
}
