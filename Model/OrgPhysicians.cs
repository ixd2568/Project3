using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("row")]
    public class OrgPhysicians
    {
        public OrgPhysicians(string lName, string fName, string mName, int organizationId, string type, string name, string city, int zip, string county, string state, string phone)
        {
            this.lName = lName;
            this.fName = fName;
            this.mName = mName;
            this.organizationId = organizationId;
            this.type = type;
            this.name = name;
            this.city = city;
            this.zip = zip;
            this.county = county;
            this.state = state;
            this.phone = phone;
        }

        public OrgPhysicians() { }

        [XmlElement("lName")]
        public string lName { get; set; }

        [XmlElement("fName")]
        public string fName { get; set; }

        [XmlElement("mName")]
        public string mName { get; set; }

        [XmlElement("OrganizationID")]
        public int organizationId { get; set; }

        [XmlElement("type")]
        public string type { get; set; }

        [XmlElement("Name")]
        public string name { get; set; }

        [XmlElement("city")]
        public string city { get; set; }

        [XmlElement("zip")]
        public int zip { get; set; }

        [XmlElement("CountyName")]
        public string county { get; set; }

        [XmlElement("State")]
        public string state { get; set; }

        [XmlElement("phone")]
        public string phone { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class OrgPhysiciansList
    {
        [XmlElement("row")]
        public List<Model.OrgPhysicians> physicians { get; set; }

        public OrgPhysiciansList()
        {
            this.physicians = new List<Model.OrgPhysicians>();
        }
    }
}
