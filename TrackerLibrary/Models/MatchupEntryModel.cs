 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one team in matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Player id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The unique indentifier for the team.
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Team competing in tournament.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// The score of a match.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// The unique indentifier for the parent mtachup (team).
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// The opponent for team in concrete match.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
