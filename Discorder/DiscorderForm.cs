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
    public partial class DiscorderForm : Form
    {
        public DiscorderForm()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            

            
          

            SearchResultList exactList;
            SearchResultList results;
            Discogs.Search("It Began In Afrika",SearchType.all, 1, out results, out exactList);
            ArtistDetails a = Discogs.GetArtist("Aphex Twin");
            LabelDetails l = Discogs.GetLabel("Tidy");
            ReleaseDetails r = Discogs.GetRelease(95682);


            
        }
    }
}
