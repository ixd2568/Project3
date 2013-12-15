using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("facility")]
    public class Facilities
    {
        public Facilities(int typeId, string type, int quantity, string description) 
        { 
            this.typeId = typeId; 
            this.type = type; 
            this.quantity = quantity; 
            this.description = description; 
        }

        public Facilities() { }

        [XmlElement("typeId")]
        public int typeId { get; set; }
        
        [XmlElement("type")]
        public string type { get; set; }
        
        [XmlElement("quantity")]
        public int quantity { get; set; }

        [XmlElement("description")]
        public string description { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class FacilitiesList
    {
        [XmlElement("facility")]
        public List<Model.Facilities> facilities { get; set; }

        public FacilitiesList()
        {
            this.facilities = new List<Model.Facilities>();
        }
    }
}
