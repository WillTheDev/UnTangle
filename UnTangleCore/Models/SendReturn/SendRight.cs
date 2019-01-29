﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.SendReturn
{
    /// <summary>
    /// Specific settings for the Send Mono Right model.
    /// </summary>
    [DataContract]
    public class SendRight : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public SendRight()
        {
            DisplayName = ConstSendReturn.DISP_SEND_MONO_2;
        }

        [DataMember]
        public float DryThru { get; set; }

        [DataMember]
        public float Send { get; set; }
			
    };
}
