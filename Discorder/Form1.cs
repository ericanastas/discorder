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
            

            
          

            REST.SearchResultList exactList;
            REST.SearchResultList results;
            DiscogSite.Search("Chemical Brothers", out results, out exactList);
            REST.ArtistDetails a = DiscogSite.GetArtist("Aphex Twin");
            REST.LabelDetails l = DiscogSite.GetLabel("Tidy");
            REST.ReleaseDetails r = DiscogSite.GetRelease(1138729);


            
        }
    }
}
