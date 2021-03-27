using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent Matchup List and information about round.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Player id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Id from databese, to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// The list of matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The round of list with matchups.
        /// </summary>
        public int MatchupRound { get; set; }
        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
