using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Discorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            //DiscogSite.Search("Chemical Brothers");
            DiscogSite.GetXmlResponse(@"http://www.discogs.com/search?type=all&q=Chemical Brothers&f=xml&api_key=7ccd6b4264");
        }
    }
}
