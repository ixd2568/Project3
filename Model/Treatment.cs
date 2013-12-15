using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("treatment")]
    public class Treatment
    {
        public Treatment(int typeId, string type, string abbreviation)
        {
            this.typeId = typeId;
            this.type = type;
            this.abbreviation = abbreviation;
        }

        public Treatment() { }

        [XmlElement("typeId")]
        public int typeId { get; set; }

        [XmlElement("type")]
        public string type { get; set; }

        [XmlElement("description")]
        public string abbreviation { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class TreatmentList
    {
        [XmlElement("treatment")]
        public List<Model.Treatment> treatment { get; set; }

        public TreatmentList()
        {
            this.treatment = new List<Model.Treatment>();
        }
    }
}
