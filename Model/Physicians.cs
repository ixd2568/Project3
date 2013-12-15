using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("physician")]
    public class Physicians
    {
        public Physicians(int personId, string fName, string mName, string lName, string suffix, string phone, int license)
        {
            this.personId = personId;
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.suffix = suffix;
            this.phone = phone;
            this.license = license;
        }

        public Physicians() { }

        [XmlElement("personId")]
        public int personId { get; set; }

        [XmlElement("fName")]
        public string fName { get; set; }

        [XmlElement("mName")]
        public string mName { get; set; }

        [XmlElement("lName")]
        public string lName { get; set; }

        [XmlElement("suffix")]
        public string suffix { get; set; }

        [XmlElement("phone")]
        public string phone { get; set; }

        [XmlElement("license")]
        public int license { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class PhysiciansList
    {
        [XmlElement("physician")]
        public List<Model.Physicians> physicians { get; set; }

        public PhysiciansList()
        {
            this.physicians = new List<Model.Physicians>();
        }
    }
}
