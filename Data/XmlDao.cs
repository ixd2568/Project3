using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Project3.Data
{
    class XmlDao
    {
        const string DATA_URL = "http://simon.ist.rit.edu:8080/Services/resources/ESD/";

        /// <summary>
        /// Each of the following methods uses an ID as a parameter to get the appropriate list, then returns it
        /// Returns 0 in case of error (WHICH MIGHT HAPPEN SOMETIMES BECAUSE THIS XML FILE SURE IS BRILLIANTLY DESIGNED)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Tabs> getData(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.TabsList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + "Application/Tabs?orgId=" + id);
                request.Method = "GET";
                Model.TabsList tabs = (Model.TabsList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return tabs.tabs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Model.General getGeneral(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.General));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/General");
                request.Method = "GET";
                Model.General general = (Model.General)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return general;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Facilities> getFacilities(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.FacilitiesList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Facilities");
                request.Method = "GET";
                Model.FacilitiesList facilities = (Model.FacilitiesList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return facilities.facilities;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Locations> getLocations (int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.LocationsList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Locations");
                request.Method = "GET";
                Model.LocationsList locations = (Model.LocationsList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return locations.locations;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Training> getTraining(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.TrainingList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Training");
                request.Method = "GET";
                Model.TrainingList training = (Model.TrainingList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return training.training;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Treatment> getTreatments(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.TreatmentList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Treatments");
                request.Method = "GET";
                Model.TreatmentList treatment = (Model.TreatmentList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return treatment.treatment;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Model.Equipment> getEquipment(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.EquipmentList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Equipment");
                request.Method = "GET";
                Model.EquipmentList equipment = (Model.EquipmentList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return equipment.equipment;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Physicians> getPhysicians(int id)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.PhysiciansList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/Physicians");
                request.Method = "GET";
                Model.PhysiciansList physicians = (Model.PhysiciansList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return physicians.physicians;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// This one is slightly different since it has to parse subelements too, so an additional class was needed
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.People> getPeople(int id)
        {
            try
            {
                List<Model.People> listOfPeople = new List<Model.People>();

                XmlSerializer serializer = new XmlSerializer(typeof(Model.SiteList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + id + "/People");
                request.Method = "GET";
                Model.SiteList sites = (Model.SiteList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                foreach (Model.PeopleList people in sites.sites)
                {
                    foreach (Model.People person in people.people)
                    {
                        listOfPeople.Add(person);
                    }
                }

                return listOfPeople;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.OrgTypes> getOrgTypes()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.OrgTypesList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + "OrgTypes");
                request.Method = "GET";
                Model.OrgTypesList orgTypes = (Model.OrgTypesList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return orgTypes.orgTypes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Model.Cities> getCities(string state)
        {
            if (state.Equals(""))
                return null;
            else
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Model.CitiesList));
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + "Cities?state=" + state);
                    request.Method = "GET";
                    Model.CitiesList cities = (Model.CitiesList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                    return cities.cities;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets the user's requested results based on form data
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public List<Model.Organization> getSearchResults(Model.Organization organization)
        {
            string serializedForm = "";
            if (!organization.type.Equals(""))
                serializedForm += "type=" + organization.type + "&";
            if (!organization.name.Equals(""))
                serializedForm += "name=" + organization.name + "&";
            if (!organization.state.Equals(""))
                serializedForm += "state=" + organization.state + "&";
            if (!organization.city.Equals(""))
                serializedForm += "town=" + organization.city + "&";
            if (!organization.county.Equals(""))
                serializedForm += "county=" + organization.county + "&";
            if (!organization.zip.Equals(""))
                serializedForm += "zip=" + organization.zip;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.OrganizationList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + "Organizations?" + serializedForm);
                request.Method = "GET";
                Model.OrganizationList organizations = (Model.OrganizationList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return organizations.organizations;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Same, except for physicians
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public List<Model.OrgPhysicians> getPhysicianSearchResults(Model.Organization organization)
        {
            string serializedForm = "";
            if (!organization.type.Equals(""))
                serializedForm += "type=" + organization.type + "&";
            if (!organization.name.Equals(""))
                serializedForm += "name=" + organization.name + "&";
            if (!organization.state.Equals(""))
                serializedForm += "state=" + organization.state + "&";
            if (!organization.city.Equals(""))
                serializedForm += "town=" + organization.city + "&";
            if (!organization.county.Equals(""))
                serializedForm += "county=" + organization.county + "&";
            if (!organization.zip.Equals(0))
                serializedForm += "zip=" + organization.zip;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Model.OrgPhysiciansList));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DATA_URL + "Organizations?" + serializedForm);
                request.Method = "GET";
                Model.OrgPhysiciansList physicians = (Model.OrgPhysiciansList)serializer.Deserialize(((HttpWebResponse)request.GetResponse()).GetResponseStream());

                return physicians.physicians;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
