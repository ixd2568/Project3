using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("training")]
    public class Training
    {
        public Training(int typeId, string type, string abbreviation)
        {
            this.typeId = typeId;
            this.type = type;
            this.abbreviation = abbreviation;
        }

        public Training() { }

        [XmlElement("typeId")]
        public int typeId { get; set; }

        [XmlElement("type")]
        public string type { get; set; }

        [XmlElement("description")]
        public string abbreviation { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class TrainingList
    {
        [XmlElement("training")]
        public List<Model.Training> training { get; set; }

        public TrainingList()
        {
            this.training = new List<Model.Training>();
        }
    }
}
