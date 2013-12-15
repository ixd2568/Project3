using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3.Model
{
    [XmlType("row")]
    public class Tabs
    {
        public Tabs(string tab)
        {
            this.tab = tab;
        }

        public Tabs() { }

        [XmlElement("Tab")]
        public string tab { get; set; }
    }

    [Serializable, XmlRoot("data"), XmlType("data")]
    public class TabsList
    {
        [XmlElement("row")]
        public List<Model.Tabs> tabs { get; set; }

        public TabsList()
        {
            this.tabs = new List<Model.Tabs>();
        }
    }
}
