using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropDown.DataSource = rounds;
            matchupListbox.DataSource = selectedMatchups;
            matchupListbox.DisplayMember = "DisplayName";
        }


        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                    
                }
            }

            LoadMatchups(1);
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach(MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }

                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreText.Visible = isVisible;
            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreText.Visible = isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;

        }

        private void LoadMatchup(MatchupModel m)
        {

            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamOneScoreText.Text = m.Entries[0].Score.ToString();

                            teamTwoName.Text = "<bye>";
                            teamTwoScoreText.Text = "0";
                        }
                        else
                        {
                            teamOneName.Text = "Not Yet Set";
                            teamOneScoreText.Text = "";
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                            teamTwoScoreText.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            teamTwoName.Text = "Not Yet Set";
                            teamTwoScoreText.Text = "";
                        }
                    }

                } 
            }
        }

        private void matchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListbox.SelectedItem);
        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreText.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);
            if(!scoreOneValid && !scoreTwoValid)
            {
                output = "The score values are not a valid numbers!";
            }
            else if(!scoreOneValid)
            {
                output = "The score One value is not a valid number!";
            }
            else if(!scoreTwoValid)
            {
                output = "The score Two value is not a valid number!";
            }
            else if(teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score!";
            }
            else if(teamOneScore == teamTwoScore)
            {
                output = "This is a draw, continue playing! We need a winner!";
            }
            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(ValidateData());
                return;
            }

            MatchupModel m = (MatchupModel)matchupListbox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            bool scoreValid = double.TryParse(teamOneScoreText.Text, out teamOneScore);

                            if (scoreValid)
                            {
                                m.Entries[0].Score = teamOneScore; 
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team one.");
                                return;
                            }
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            bool scoreValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);

                            if (scoreValid)
                            {
                                m.Entries[1].Score = teamTwoScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team two.");
                                return;
                            }
                        }
                    }

                }

                try
                {
                    TournamentLogic.UpdateTournamentResults(tournament);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"The application had an error: {ex.Message}");
                    return;
                }

                LoadMatchups((int)roundDropDown.SelectedItem);
            }
        }
    }
}
