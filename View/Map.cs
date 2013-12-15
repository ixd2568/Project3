using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.View
{
    public partial class Map : Form
    {
        Form parent;

        public Map()
        {
            InitializeComponent();
            this.parent = null;
        }

        public Map(Form parent, string url)
        {
            InitializeComponent();
            this.webBrowser1.Navigate(url);
            this.parent = parent;
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
