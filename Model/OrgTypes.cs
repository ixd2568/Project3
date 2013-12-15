using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{

    [XmlType("row")]
    public class OrgTypes
    {
        public OrgTypes(int typeId, string type)
        {
            this.typeId = typeId;
            this.type = type;
        }

        public OrgTypes() { }

        [XmlElement("typeId")]
        public int typeId { get; set; }

        [XmlElement("type")]
        public string type { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class OrgTypesList
    {
        [XmlElement("row")]
        public List<Model.OrgTypes> orgTypes { get; set; }

        public OrgTypesList()
        {
            this.orgTypes = new List<Model.OrgTypes>();
        }
    }
}
