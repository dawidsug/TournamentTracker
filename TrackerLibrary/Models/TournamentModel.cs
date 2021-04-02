using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent all information about tournament with list of rounds and list of teams and prices
    /// and have the name and entry fee
    /// </summary>
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;
        /// <summary>
        /// Player id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Tournament name.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry fee for each team in tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of teams in tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prizes in tournament (in amount or perentage).
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Number of rounds in tournaments. It will depand on number of teams.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
