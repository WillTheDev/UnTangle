using System;
using System.Runtime.Serialization;

namespace UnTangle.Core.Models
{
    [DataContract]
    public class Meta
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Application { get; set; }

        [DataMember]
        public string Build_sha { get; set; }

        [DataMember]
        public long ModifiedDate
        {
            get
            {
                return (new DateTimeOffset(LocalModifiedDate.Ticks, DateTimeOffset.Now.Offset).ToUnixTimeSeconds());
            }
            set
            {
                // Unix time-stamp is seconds past epoch
                LocalModifiedDate = DateTimeOffset.FromUnixTimeSeconds(value).ToLocalTime();
            }
        }

        [DataMember]
        public int Appversion { get; set; }

        /// <summary>
        /// Stores the Local Date and Time converted from the file time-stamp.
        /// </summary>
        public DateTimeOffset LocalModifiedDate { get; set; }
    }
}
