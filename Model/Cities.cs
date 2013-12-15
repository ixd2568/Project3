using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("row")]
    public class Cities
    {
        public Cities(string city)
        {
            this.city = city;
        }

        public Cities() {}

        [XmlElement("city")]
        public string city { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class CitiesList
    {
        [XmlElement("row")]
        public List<Model.Cities> cities { get; set; }

        public CitiesList()
        {
            this.cities = new List<Model.Cities>();
        }
    }
}
