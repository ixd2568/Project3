using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [Serializable, XmlRoot("data"), XmlType("data")]
    public class General
    {

        [XmlElement("name")]
        public string name { get; set; }

        [XmlElement("description")]
        public string description { get; set; }

        [XmlElement("email")]
        public string email { get; set; }

        [XmlElement("website")]
        public string website { get; set; }

        [XmlElement("nummembers")]
        public int nummembers { get; set; }

        [XmlElement("numcalls")]
        public int numcalls { get; set; }

        [XmlElement("servicearea")]
        public string servicearea { get; set; }
    } 
}
