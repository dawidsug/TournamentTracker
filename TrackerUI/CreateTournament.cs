using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        private List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeams_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournament()
        {
            InitializeComponent();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            teamDropDown.DataSource = null;
            teamDropDown.DataSource = availableTeams;
            teamDropDown.DisplayMember = "TeamName";

            teamsPlayersListbox.DataSource = null;
            teamsPlayersListbox.DataSource = selectedTeams;
            teamsPlayersListbox.DisplayMember = "TeamName";

            prizesListbox.DataSource = null;
            prizesListbox.DataSource = selectedPrizes;
            prizesListbox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel tm = (TeamModel)teamDropDown.SelectedItem;

            if (tm != null)
            {
                selectedTeams.Add(tm);
                availableTeams.Remove(tm);
                WiredUpLists(); 
            }
        }

        private void teamsPlayersDelete_Click(object sender, EventArgs e)
        {
            TeamModel tm = (TeamModel)teamsPlayersListbox.SelectedItem;

            if (tm != null)
            {
                selectedTeams.Remove(tm);
                availableTeams.Add(tm);
                WiredUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrize frm = new CreatePrize(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WiredUpLists();
        }
        private void createNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam ctf = new CreateTeam(this);
            ctf.Show();
        }
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WiredUpLists();
        }

        private void prizesDelete_Click(object sender, EventArgs e)
        {
            PrizeModel pm = (PrizeModel)prizesListbox.SelectedItem;

            if(pm != null)
            {
                selectedPrizes.Remove(pm);
                WiredUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = Decimal.TryParse(entryFeeText.Text, out fee);
            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameText.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            
            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }
    }
}
