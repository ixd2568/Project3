using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("person")]
    public class People
    {
        public People(int personId, string honorific, string fName, string mName, string lName, string suffix, string role, string contactmethods)
        {
            this.personId = personId;
            this.honorific = honorific;
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.suffix = suffix;
            this.role = role;
            this.contactmethods = contactmethods;
        }

        public People() { }

        [XmlElement("personId")]
        public int personId { get; set; }

        [XmlElement("honorific")]
        public string honorific { get; set; }
        
        [XmlElement("fName")]
        public string fName { get; set; }

        [XmlElement("mName")]
        public string mName { get; set; }

        [XmlElement("lName")]
        public string lName { get; set; }

        [XmlElement("suffix")]
        public string suffix { get; set; }

        [XmlElement("role")]
        public string role { get; set; }

        [XmlElement("contactmethods")]
        public string contactmethods { get; set; }
    }

    public class PeopleList
    {
        [XmlElement("person")]
        public List<Model.People> people { get; set; }

        public PeopleList()
        {
            this.people = new List<Model.People>();
        }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class SiteList
    {
        [XmlElement("site")]
        public List<Model.PeopleList> sites { get; set; }

        public SiteList()
        {
            this.sites = new List<Model.PeopleList>();
        }
    }
}
