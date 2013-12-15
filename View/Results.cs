using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.View
{
    public partial class Results : Form
    {
        private Form parent;
        private bool mouseClicked;

        public Results()
        {
            InitializeComponent();
            
            parent = null;
            mouseClicked = false;
        }

        /// <summary>
        /// Displays the results if a list of organizations is provided
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="organizationList"></param>
        public Results(Form parent, List<Model.Organization> organizationList)
        {
            InitializeComponent();

            this.parent = parent;
            this.mouseClicked = false;

            orgData.DataSource = organizationList.Select(o => new {ID = o.id, Type = o.type, Name = o.name, City = o.city, Zip = o.zip, County = o.county, State = o.state }).ToList();
 
        }

        /// <summary>
        /// Displays the results if a list of physicians is provided
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="physiciansList"></param>
        public Results(Form parent, List<Model.OrgPhysicians> physiciansList)
        {
            InitializeComponent();

            this.parent = parent;
            this.mouseClicked = false;

            orgData.DataSource = physiciansList.Select(o => new {ID = o.organizationId, Name = o.lName + ", " + o.mName + " " + o.fName, Phone = o.phone, Employer = o.name, City = o.city, Zip = o.zip, State = o.state }).ToList();
        }

        /// <summary>
        /// Show the search form when this form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        /// <summary>
        /// When the user clicks on a row, displays the details for that organization
        /// (based on ID)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orgData_SelectionChanged(object sender, EventArgs e)
        {
            if (mouseClicked)
            {
                int index = orgData.CurrentCell.RowIndex;

                DataGridViewRow selectedRow = orgData.Rows[index];

                int id = (int)selectedRow.Cells[0].Value;

                Form Details = new Details(this, id);
                Details.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Tracks mouse clicks to ensure that SelectionChanged triggers only on user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orgData_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        /// <summary>
        /// Tracks mouse clicks to ensure that SelectionChanged triggers only on user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orgData_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
