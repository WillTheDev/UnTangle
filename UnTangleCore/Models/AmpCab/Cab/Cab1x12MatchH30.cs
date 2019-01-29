using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Match H30 cabinet model.
    /// </summary>
    [DataContract]
    public class Cab1x12MatchH30 : CabBase
    {
        public Cab1x12MatchH30()
        {
            DisplayName = ConstCab.DISP_1X12_MATCH_H30;
        }

    };
}
