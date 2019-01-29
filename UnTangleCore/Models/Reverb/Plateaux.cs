using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Reverb
{
    /// <summary>
    /// Specific settings for the Plateaux reverb model.
    /// </summary>
    [DataContract]
    public class Plateaux : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Plateaux()
        {
            DisplayName = ConstReverb.DISP_PLATEAUX;
        }

        [DataMember]
        public float Modulation { get; set; }

        [DataMember]
        public float Cents2 { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public int Pitch1 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Tone { get; set; }

        [DataMember]
        public float Decay { get; set; }

        [DataMember]
        public int Pitch2 { get; set; }

        [DataMember]
        public float Cents1 { get; set; }

        [DataMember]
        public float PitchMix { get; set; }

        [DataMember]
        public float Predelay { get; set; }

    };
}
