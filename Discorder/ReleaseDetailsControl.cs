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
        private ReleaseDetails _currentRelease = null;


        private ReleaseDetails CurrentRelease
        {
            get
            {
                return this._currentRelease;
            }
            set
            {
                this._currentRelease = value;

                if (value == null)
                {
                    //title
                    titleLbl.Text = "";

                    //label
                    labelLbl.Text = "";

                    //released
                    releasedLbl.Text = "";

                    //country
                    countryLbl.Text = "";

                    //genres
                    genresLbl.Text = "";

                    //styles
                    stylesLbl.Text = "";

                    //formats
                    formatsLbl.Text = "";

                    //notes
                    notesTextBox.Text = "";

                    //images
                    imagesListBox.Items.Clear();
                    pictureBox.Image = null;

                    //tracks
                    tracksOLV.Clear();
                }
                else
                {
                    //title
                    titleLbl.Text = value.Title;

                    //label
                    String labelString = "";
                    for (int i = 0; i < value.Labels.Length; i++)
                    {
                        if (i > 0)
                        {
                            labelString += " | ";
                        }

                        labelString += value.Labels[i].Name;
                        labelString += " (";
                        labelString += value.Labels[i].CatalogNumber;
                        labelString += ")";
                    }
                    labelLbl.Text = labelString;


                    //released
                    releasedLbl.Text = value.Released;

                    //country
                    countryLbl.Text = value.Country;

                    //genres
                    String genresString = String.Empty;
                    for (int i = 0; i < value.Genres.Length; i++)
                    {
                        if (i > 0) genresString += ", ";
                        genresString += value.Genres[i];
                    }
                    genresLbl.Text = genresString;

                    //styles
                    String stylesSTring = String.Empty;
                    for (int i = 0; i < value.Styles.Length; i++)
                    {
                        if (i > 0) stylesSTring += ", ";
                        stylesSTring += value.Styles[i];
                    }
                    stylesLbl.Text = stylesSTring;

                    //formats
                    String formatsString = String.Empty;
                    for (int i = 0; i < value.Formats.Length; i++)
                    {
                        if (i > 0) formatsString += " | ";

                        
                        formatsString += value.Formats[i].Quanity.ToString();
                        formatsString += " x ";
                        formatsString += value.Formats[i].Name;
                        if (value.Formats[i].Descriptions != null && value.Formats[i].Descriptions.Length > 0)
                        {
                            formatsString += ", ";
                            formatsString += value.Formats[i].Descriptions;
                        }
                        

          
                    }
                    formatsLbl.Text = formatsString;

                    //notes
                    notesTextBox.Text = value.Notes;

                    //images



                    

                    //tracks
                    tracksOLV.SetObjects(value.TrackList);
                }


            }
        }
    }
}
