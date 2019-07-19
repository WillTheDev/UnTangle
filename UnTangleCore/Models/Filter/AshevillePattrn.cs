using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.Filter
{
    /// <summary>
    /// Specific settings for the Asheville Pattrn Filter model.
    /// </summary>
    [DataContract]
    public class AshevillePattrn : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public AshevillePattrn()
        {
            DisplayName = ConstFilter.DISP_ASHEVILLE_PATTRN;
        }

        [DataMember]
        public bool Direction { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Envelope { get; set; }

        [DataMember]
        public float LFO { get; set; }

        [DataMember]
        public float Level1 { get; set; }

        [DataMember]
        public float Level2 { get; set; }

        [DataMember]
        public float Level3 { get; set; }

        [DataMember]
        public float Level4 { get; set; }

        [DataMember]
        public float Level5 { get; set; }

        [DataMember]
        public float Level6 { get; set; }

        [DataMember]
        public float Level7 { get; set; }

        [DataMember]
        public float Level8 { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public int Pattern { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float Spread { get; set; }

        [DataMember]
        public int SyncSelect1 { get; set; }

        [DataMember]
        public int SyncSelect2 { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public bool TempoSync2 { get; set; }

        [DataMember]
        public bool Voice { get; set; }
    };
}
