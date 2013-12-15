using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    /// <summary>
    /// Organization data object
    /// </summary>
    [XmlType("row")]
    public class Organization
    {
        public Organization(int id, string type, string name, string email, string city, string zip, string county, string state)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.email = email;
            this.city = city;
            this.zip = zip;
            this.county = county;
            this.state = state;
        }

        public Organization(string type, string name, string city, string zip, string county, string state)
        {
            this.type = type;
            this.name = name;
            this.city = city;
            this.zip = zip;
            this.county = county;
            this.state = state;
        }

        public Organization() { }

        [XmlElement("OrganizationID")]
        public int id { get; set; }

        [XmlElement("type")]
        public string type { get; set; }

        [XmlElement("Name")]
        public string name { get; set; }

        [XmlElement("Email")]
        public string email { get; set; }

        [XmlElement("city")]
        public string city { get; set; }

        [XmlElement("zip")]
        public string zip { get; set; }

        [XmlElement("CountyName")]
        public string county { get; set; }

        [XmlElement("State")]
        public string state { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class OrganizationList
    {
        [XmlElement("row")]
        public List<Model.Organization> organizations { get; set; }

        public OrganizationList()
        {
            this.organizations = new List<Model.Organization>();
        }
    }
}
