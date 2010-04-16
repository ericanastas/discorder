using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Discorder
{
    public partial class ReleaseDetailsControl : UserControl
    {
        public ReleaseDetailsControl()
        {
            InitializeComponent();
        }


        private ReleaseDetails _release;
        public ReleaseDetails Release
        {
            get
            {
                return _release;
            }
            set
            {
                this._release = value;
                this.Track = null;

                if (value == null)
                {

                    //Title
                    titleLbl.Text = "<No Release Selected>";

                    //lable
                    labelLbl.Text = String.Empty;

                    //release
                    releaseLbl.Text = String.Empty;

                    //country
                    countryLbl.Text = String.Empty;

                    //genres
                    genresLbl.Text = String.Empty;

                    //styles
                    stylesLbl.Text = String.Empty;

                    //formats
                    formatsLbl.Text = String.Empty;

                    //notes
                    notesTextBox.Text = String.Empty;

                    //imagelist
                    imagesListBox.Items.Clear();

                    //image
                    releaseLbl.Image = null;

                    //tracklistOLV
                    tracksOLV.ClearObjects();

                    return;
                }


                //Title
                titleLbl.Text = value.Title;

                //label string
                StringBuilder labelStringBuilder = new StringBuilder();
                if (value.Labels != null)
                {
                    for (int i = 0; i < value.Labels.Length; i++)
                    {
                        if (i > 0)
                        {
                            labelStringBuilder.Append(", ");
                        }

                        labelStringBuilder.Append(value.Labels[i].Name);
                        labelStringBuilder.Append(" (");
                        labelStringBuilder.Append(value.Labels[i].CatalogNumber);
                        labelStringBuilder.Append(")");
                    }
                }
                labelLbl.Text = labelStringBuilder.ToString();

                //release
                releaseLbl.Text = value.Released;

                //country
                countryLbl.Text = value.Country;

                //genres
                StringBuilder genresStringBuilder = new StringBuilder();
                for (int i = 0; i < value.Genres.Length; i++)
                {
                    if (i > 0)
                    {
                        genresStringBuilder.Append(", ");
                    }
                    genresStringBuilder.Append(value.Genres[i]);
                }
                genresLbl.Text = genresStringBuilder.ToString();

                //styles
                StringBuilder stylesStringBuilder = new StringBuilder();
                if (value.Styles != null)
                {
                    for (int i = 0; i < value.Styles.Length; i++)
                    {
                        if (i > 0)
                        {
                            stylesStringBuilder.Append(", ");
                        }
                        stylesStringBuilder.Append(value.Styles[i]);
                    }
                }
                stylesLbl.Text = stylesStringBuilder.ToString();

                //formats
                StringBuilder formatesStringBuilder = new StringBuilder();
                if (value.Formats != null)
                {
                    for (int i = 0; i < value.Formats.Length; i++)
                    {
                        if (i > 0)
                        {
                            formatesStringBuilder.Append(" | ");
                        }

                        formatesStringBuilder.Append(value.Formats[i].Quanity.ToString());
                        formatesStringBuilder.Append(" x ");
                        formatesStringBuilder.Append(value.Formats[i].Name);

                        if (value.Formats[i].Descriptions != null)
                        {
                            for (int j = 0; j < value.Formats[i].Descriptions.Length; j++)
                            {
                                formatesStringBuilder.Append(", ");
                                formatesStringBuilder.Append(value.Formats[i].Descriptions[j]);
                            }
                        }
                    }
                }
                formatsLbl.Text = formatesStringBuilder.ToString();

                //notes
                notesTextBox.Text = value.Notes;

                //images
                ImageList iList = new ImageList();
                iList.ImageSize = new Size(150, 150);
                imagesListBox.Items.Clear();

                if (value.Images != null)
                {
                    for (int i = 0; i < value.Images.Length; i++)
                    {
                        imagesListBox.Items.Add("Image " + (i + 1).ToString());
                    }
                }


                //tracklistOLV
                tracksOLV.SetObjects(value.TrackList);
                tracksOLV.Sort(positionCol, SortOrder.Ascending);

                OnReleaseChanged(new ReleaseChangedEventArgs(value));
                

            }

        }


        private TrackInfo _track;
        public TrackInfo Track
        {
            get
            {
                return this._track;
            }
            set
            {
                if (this._track != value)
                {
                    this._track = value;
                    OnTrackChanged(new TrackChangedEventArgs(value));
                }
                    
            }
        }

        private void tracksOLV_SelectionChanged(object sender, EventArgs e)
        {
            this.Track = (TrackInfo)tracksOLV.SelectedObject;
        }

        public class TrackChangedEventArgs : System.EventArgs
        {
            public TrackChangedEventArgs(TrackInfo SelectedTrack)
            {
                this.SelectedTrack = SelectedTrack;
            }
            public TrackInfo SelectedTrack { get; private set; }
        }
        public event EventHandler<TrackChangedEventArgs> TrackChanged;
        protected virtual void OnTrackChanged(TrackChangedEventArgs e)
        {
            var handler = TrackChanged;
            if (handler != null)
                handler(this, e);
        }





        public class ReleaseChangedEventArgs : System.EventArgs
        {
            public ReleaseChangedEventArgs(ReleaseDetails SelectedRelease)
            {
                this.SelectedRelease = SelectedRelease;
            }
            public ReleaseDetails SelectedRelease { get; private set; }
        }
        public event EventHandler<ReleaseChangedEventArgs> ReleaseChanged;
        protected virtual void OnReleaseChanged(ReleaseChangedEventArgs e)
        {
            var handler = ReleaseChanged;
            if (handler != null)
                handler(this, e);
        }

    }
}
