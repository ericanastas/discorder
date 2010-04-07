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


 





        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchResultList exactList;
            SearchResultList results;
            Discogs.Search("It Began In Afrika", SearchType.all, 1, out results, out exactList);
            ArtistDetails a = Discogs.GetArtist("Aphex Twin");
            LabelDetails l = Discogs.GetLabel("Tidy");
            ReleaseDetails r = Discogs.GetRelease(95682);
        }

        private void collapseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftRightSplitContainer.Panel2Collapsed)
            {
                leftRightSplitContainer.Panel2Collapsed = false;
            }
            else
            {
                leftRightSplitContainer.Panel2Collapsed = true;
            }
        }

        private void collapseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (leftRightSplitContainer.Panel1Collapsed)
            {
                leftRightSplitContainer.Panel1Collapsed = false;
            }
            else
            {
                leftRightSplitContainer.Panel1Collapsed = true;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.searchTextBox.Text))
            {
                DiscogsSearchVirtualDataSource dSource = new DiscogsSearchVirtualDataSource(SearchType.releases, this.searchTextBox.Text);
                searchResultListView.DataSource = dSource;
            }
            else
            {
                searchResultListView.DataSource = null;

            }



        }

        private void searchResultListView_SelectionChanged(object sender, EventArgs e)
        {

            if (searchResultListView.SelectedItem == null) return;

            SearchResult selectedResult = (SearchResult)searchResultListView.SelectedObject;

            if (selectedResult.type == SearchResultType.release)
            {
                string uri = selectedResult.uri;
                char[] delim = new char[1];
                delim[0] = '/';
                string[] splitItems = uri.Split(delim);
                int releaseNum = System.Convert.ToInt32(splitItems[splitItems.Length - 1]);
                ReleaseDetails rDetails = Discogs.GetRelease(releaseNum);
                releaseDetailsControl.Release = rDetails;
            }
            else
            {
                releaseDetailsControl.Release = null;
            }
        }


    }
}
