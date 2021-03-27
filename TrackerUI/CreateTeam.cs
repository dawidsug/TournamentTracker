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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            WiredUpLists();
            
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Mark", LastName = "Besos" });
        }
        private void WiredUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            playersListbox.DataSource = null;

            playersListbox.DataSource = selectedTeamMembers;
            playersListbox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameText.Text;
                p.LastName = lastNameText.Text;
                p.EmailAddress = emailText.Text;
                p.CellphoneNumber = cellphoneText.Text;

                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);

                WiredUpLists();

                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                cellphoneText.Text = "";


            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private bool ValidateForm()
        {
            if(firstNameText.Text.Length == 0)
            {
                return false;
            }
            if (lastNameText.Text.Length == 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(emailText.Text))
            {
                return false;
            }
            if (cellphoneText.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WiredUpLists(); 
            }
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)playersListbox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                WiredUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameText.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
            
        }
    }
}
