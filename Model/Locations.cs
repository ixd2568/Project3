using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("location")]
    public class Locations
    {
        public Locations(string type, string address1, string address2, string city, string state, int zip, string phone, string ttyPhone, string fax, string latitude, string longitude, int countyId, string countyName, int siteId)
        {
            this.type = type;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.ttyPhone = ttyPhone;
            this.fax = fax;
            this.latitude = latitude;
            this.longitude = longitude;
            this.countyId = countyId;
            this.countyName = countyName;
            this.siteId = siteId;
        }

        public Locations() { }
        
        [XmlElement("type")]
        public string type { get; set; }

        [XmlElement("address1")]
        public string address1 { get; set; }

        [XmlElement("address2")]
        public string address2 { get; set; }

        [XmlElement("city")]
        public string city { get; set; }

        [XmlElement("state")]
        public string state { get; set; }

        [XmlElement("zip")]
        public int zip { get; set; }

        [XmlElement("phone")]
        public string phone { get; set; }

        [XmlElement("ttyPhone")]
        public string ttyPhone { get; set; }

        [XmlElement("fax")]
        public string fax { get; set; }

        [XmlElement("latitude")]
        public string latitude { get; set; }

        [XmlElement("longitude")]
        public string longitude { get; set; }

        [XmlElement("countyId")]
        public int countyId { get; set; }

        [XmlElement("countyName")]
        public string countyName { get; set; }

        [XmlElement("siteId")]
        public int siteId { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class LocationsList
    {
        [XmlElement("location")]
        public List<Model.Locations> locations { get; set; }

        public LocationsList()
        {
            this.locations = new List<Model.Locations>();
        }
    }
}
