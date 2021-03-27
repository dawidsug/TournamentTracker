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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameText.Text, 
                    placeNumberText.Text, 
                    placeAmountText.Text, 
                    prizePercentageText.Text);
                
                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidator = int.TryParse(placeNumberText.Text, out placeNumber);
            if (placeNumberValidator == false)
            {
                output = false;
            }
            if(placeNumber <= 0)
            {
                output = false;
            }
            if(placeNameText.Text.Length == 0)
            {
                output = false;
            }
            decimal placeAmount;
            double placePercentage;
            bool placeAmountValidator = decimal.TryParse(placeAmountText.Text, out placeAmount);
            bool placePercentageValidator = double.TryParse(prizePercentageText.Text, out placePercentage);
            if(placeAmountValidator == false || placeAmountValidator == false)
            {
                output = false;
            }
            if (placeAmount <= 0 && placePercentage <= 0)
            {
                output = false;
            }
            if (placeAmount > 0 && placePercentage > 0)
            {
                output = false;
            }
            if (placePercentage <0 || placePercentage> 100)
            {
                output = false;
            }
            return output;
        }
    }
}
