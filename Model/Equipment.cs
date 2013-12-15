using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("equipment")]
    public class Equipment
    {
        public Equipment(int typeId, string type, int quantity, string description)
        {
            this.typeId = typeId;
            this.type = type;
            this.quantity = quantity;
            this.description = description;
        }

        public Equipment() { }

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
    public class EquipmentList
    {
        [XmlElement("equipment")]
        public List<Model.Equipment> equipment { get; set; }

        public EquipmentList()
        {
            this.equipment = new List<Model.Equipment>();
        }
    }
}
