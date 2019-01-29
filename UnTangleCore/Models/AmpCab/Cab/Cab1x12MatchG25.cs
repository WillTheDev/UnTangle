using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Cab
{
    /// <summary>
    /// Specific settings for the 1x12 Match G25 cabinet model.
    /// </summary>
    [DataContract]
    public class Cab1x12MatchG25 : CabBase
    {
        public Cab1x12MatchG25()
        {
            DisplayName = ConstCab.DISP_1X12_MATCH_G25;
        }

    };
}
