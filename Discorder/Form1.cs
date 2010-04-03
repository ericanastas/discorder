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
            

            
          

            SearchResultList exactList;
            SearchResultList results;
            Discogs.Search("Chemical Brothers", out results, out exactList);
            ArtistDetails a = Discogs.GetArtist("Aphex Twin");
            LabelDetails l = Discogs.GetLabel("Tidy");
            ReleaseDetails r = Discogs.GetRelease(1138729);


            
        }
    }
}
