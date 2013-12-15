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
    public partial class Details : Form
    {
        Data.XmlDao dao;
        List<string> listOfTabs;
        Form parent;
        int id;

        public Details()
        {
            InitializeComponent();
            dao = new Data.XmlDao();
            listOfTabs = new List<string>();
            parent = null;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="id"></param>
        public Details(Form parent, int id)
        {
            InitializeComponent();
            dao = new Data.XmlDao();
            listOfTabs = new List<string>();
            this.parent = parent;
            this.id = id;

            //create list of tabs (strings)
            List<Model.Tabs> tabsGet = dao.getData(id);
            foreach (Model.Tabs tab in tabsGet)
            {
                listOfTabs.Add(tab.tab);
            }
            
            //remove all Tabs from the TabControl that aren't in the list built above
            foreach (TabPage formTab in detailsTabs.TabPages)
            {
                if (!listOfTabs.Contains(formTab.Text))
                    detailsTabs.TabPages.Remove(formTab);
            }

            foreach (TabPage formTab in detailsTabs.TabPages)
            {
                switch (formTab.Text)
                {
                    case "General":
                        Model.General generalInfo = dao.getGeneral(id);
                        try
                        {
                            generalDescription.Text = generalInfo.description;
                        }
                        catch (NullReferenceException)
                        {
                            generalDescription.Text = "N/A";
                        }

                        try
                        {
                            generalEmail.Text = generalInfo.email;
                        }
                        catch (NullReferenceException)
                        {
                            generalEmail.Text = "N/A";
                        }

                        try
                        {
                            generalName.Text = generalInfo.name;
                        }
                        catch (NullReferenceException)
                        {
                            generalName.Text = "N/A";
                        }

                        try
                        {
                            generalNoCalls.Text = generalInfo.numcalls.ToString();
                        }
                        catch (NullReferenceException)
                        {
                            generalNoCalls.Text = "N/A";
                        }

                        try
                        {
                            generalNoMembers.Text = generalInfo.nummembers.ToString();
                        }
                        catch (NullReferenceException)
                        {
                            generalNoMembers.Text = "N/A";
                        }

                        try
                        {
                            generalWebsite.Text = generalInfo.website;
                        }
                        catch (NullReferenceException)
                        {
                            generalWebsite.Text = "N/A";
                        }
                        break;
                    case "Facilities":
                        try
                        {
                            facilitiesGridView.DataSource = dao.getFacilities(id).Select(o => new { ID = o.typeId, Type = o.type, Quantity = o.quantity, Description = o.description }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(facilitiesTab);
                        }
                        break;
                    case "Locations":
                        try
                        {
                            locationsGridView.DataSource = dao.getLocations(id).Select(o => new { Type = o.type, Address = o.address1 + " " + o.address2, City = o.city + ", " + o.state, Zip = o.zip, Phone = o.phone }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(locationsTab);
                        }
                        break;
                    case "Training":
                        try
                        {
                            trainingGridView.DataSource = dao.getTraining(id).Select(o => new { ID = o.typeId, Type = o.type, Abbreviation = o.abbreviation }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(trainingTab);
                        }
                        break;
                    case "Treatments":
                        try
                        {
                            treatmentsGridView.DataSource = dao.getTreatments(id).Select(o => new { ID = o.typeId, Type = o.type, Abbreviation = o.abbreviation }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(treatmentsTab);
                        }
                        break;
                    case "Equipment":
                        try
                        {
                            equipmentGridView.DataSource = dao.getEquipment(id).Select(o => new { ID = o.typeId, Type = o.type, Quantity = o.quantity, Description = o.description }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(equipmentTab);
                        }
                        break;
                    case "Physicians":
                        try
                        {
                            physiciansGridView.DataSource = dao.getPhysicians(id).Select(o => new { ID = o.lName + ", " + o.fName + " " + o.mName + " " + o.suffix, Phone = o.phone, License = o.license }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(physiciansTab);
                        }
                        break;
                    case "People":
                        try
                        {
                            peopleGridView.DataSource = dao.getPeople(id).Select(o => new { ID = o.lName + ", " + o.fName + " " + o.mName + " " + o.suffix, Role = o.role, Contact = o.contactmethods }).ToList();
                        }
                        catch (Exception)
                        {
                            detailsTabs.TabPages.Remove(peopleTab);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Shows parent on form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Details_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }


        /// <summary>
        /// Displays map if available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapButton_Click(object sender, EventArgs e)
        {
            List<Model.Locations> locations = dao.getLocations(id);
            
            string latitude = "";
            string longitude = "";

            foreach (Model.Locations loc in locations)
            {
                if ((loc.latitude != "") && (loc.longitude != "") && (loc.latitude != null) && (loc.longitude != null))
                {
                    latitude = loc.latitude;
                    longitude = loc.longitude;
                    break;
                }
            }

            //if location data exists, open map view and navigate to url
            //map is static so as to load faster
            if ((longitude != "") && (latitude != "") && (latitude != null) && (longitude != null))
            {
                Form map = new Map(this, "http://maps.google.com/maps/api/staticmap?center="+latitude+","+longitude+"&zoom=14&size=512x512&maptype=roadmap&markers=color:blue|"+latitude+","+longitude+"&sensor=true");
                map.Show();
                this.Hide();
            }
            //otherwise inform the user that there is no map data
            else
                System.Windows.Forms.MessageBox.Show("No location data attached.");
        }
    }
}
