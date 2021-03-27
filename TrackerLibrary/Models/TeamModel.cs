using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reperesent information about team names and have list of team members.
    /// </summary>
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Name of team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
