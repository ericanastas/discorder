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

            searchTypeComboBox.SelectedIndex = 0;


            this.resultTitleCOl.ImageGetter = new BrightIdeasSoftware.ImageGetterDelegate(this.GetSearchResultIcon);
        }


        private object GetSearchResultIcon(object o)
        {
            SearchResult s = (SearchResult)o;

            int value = -1;

            switch (s.type)
            {
                case SearchResultType.artist:
                    value = 2;
                    break;
                case SearchResultType.label:
                    value = 1;
                    break;
                case SearchResultType.release:
                    value = 0;
                    break;
            }

            return value;

        }





        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchResultList exactList;
            SearchResultList results;
            Discogs.Search("It Began In Afrika", SearchType.all, 1, out results, out exactList);
            ArtistDetails a = Discogs.GetArtist("Aphex Twin", false);
            LabelDetails l = Discogs.GetLabel("Tidy", false);
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

            SearchType type = SearchType.all;

            switch (searchTypeComboBox.SelectedIndex)
            {
                case 0:
                    type = SearchType.all;
                    break;
                case 1:
                    type = SearchType.artists;
                    break;
                case 2:
                    type = SearchType.labels;
                    break;
                case 3:
                    type = SearchType.releases;
                    break;
                case 4:
                    type = SearchType.catno;
                    break;
            }

            if (!String.IsNullOrEmpty(this.searchTextBox.Text))
            {
                DiscogsSearchVirtualDataSource dSource = new DiscogsSearchVirtualDataSource(type, this.searchTextBox.Text);
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

        private void searchResultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (searchResultListView.SelectedItem == null) return;

            SearchResult selectedResult = (SearchResult)searchResultListView.SelectedObject;


            string uri = selectedResult.uri;
            char[] delim = new char[1];
            delim[0] = '/';
            string[] splitItems = uri.Split(delim);


            switch (selectedResult.type)
            {
                

                case SearchResultType.artist:

                    
                    
                    string escapedArtistName = splitItems[splitItems.Length - 1];
                    ArtistDetails aDetails = Discogs.GetArtist(escapedArtistName, true);

                    foreach(ReleaseInfo rInfo in aDetails.releases)
                    {

                        string s = rInfo.Title;
                                        
                    }

                    break;

                case SearchResultType.label:
                    string escapedLabelName = splitItems[splitItems.Length - 1];
                    LabelDetails lDetails = Discogs.GetLabel(escapedLabelName, true);

                    foreach (ReleaseInfo rInfo in lDetails.releases)
                    {
                        string s = rInfo.Title;
                    }

                    break;
                default:
                    break;
            }

        }

    }
}
