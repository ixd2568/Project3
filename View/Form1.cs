using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        Data.XmlDao dao;

        public Form1()
        {
            InitializeComponent();
            this.dao = new Data.XmlDao();
        }

        /// <summary>
        /// Changes city comboBox contents based on state comboBox selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Model.Cities> listOfCities = dao.getCities(statesCombo.Text);

            citiesCombo.Items.Clear();

            citiesCombo.Items.Add("-All-");

            foreach (Model.Cities city in listOfCities)
                citiesCombo.Items.Add(city.city);

            if (citiesCombo.Items.Count > 0)
                citiesCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Initializes data, sets default selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            statesCombo.SelectedIndex = 35;

            List<Model.OrgTypes> listOfOrgs = dao.getOrgTypes();

            foreach (Model.OrgTypes org in listOfOrgs)
                orgTypeCombo.Items.Add(org.type);

            orgTypeCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets form data on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetFormButton_Click(object sender, EventArgs e)
        {
            orgNameBox.Text = "";
            countyBox.Text = "";
            zipBox.Text = "";
            statesCombo.SelectedIndex = 35;
            orgTypeCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Parses form data and displays the appropriate results on click
        /// Handles empty inputs most gracefully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showResultsButton_Click(object sender, EventArgs e)
        {
            Form resultsForm;

            string chosenState = statesCombo.SelectedItem.ToString();
            if (chosenState.Equals("-All-")) chosenState = "";

            string chosenCity = "";
            if (citiesCombo.SelectedItem == null)
                chosenCity = "";
            else
                chosenCity = citiesCombo.SelectedItem.ToString();

            if (chosenCity.Equals("-All-"))
                chosenCity = "";

            Model.Organization org = new Model.Organization(orgTypeCombo.SelectedItem.ToString(), orgNameBox.Text, chosenCity, zipBox.Text, countyBox.Text, chosenState);

            if (org.type.Equals("Physician"))
                resultsForm = new View.Results(this, dao.getPhysicianSearchResults(org));
            else
                resultsForm = new View.Results(this, dao.getSearchResults(org));

            resultsForm.Show();
            this.Hide();
        }
    }
}
