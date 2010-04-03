using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class ReleaseDetails
    {
        private ImageInfo[] imagesField;
        private ArtistInfo[] artistsField;
        private string titleField;
        private LabelInfo[] labelsField;
        private ArtistInfo[] extraartistsField;
        private FormatInfo[] formatsField;
        private string[] genresField;
        private string[] stylesField;
        private string countryField;
        private string releasedField;
        private string notesField;
        private TrackInfo[] tracklistField;
        private int idField;
        private ReleaseStatus statusField;


        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "images")]
        [System.Xml.Serialization.XmlArrayItemAttribute("image")]
        public ImageInfo[] Images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "artists")]
        [System.Xml.Serialization.XmlArrayItemAttribute("artist")]
        public ArtistInfo[] Artists
        {
            get
            {
                return this.artistsField;
            }
            set
            {
                this.artistsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("title")]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "labels")]
        [System.Xml.Serialization.XmlArrayItemAttribute("label")]
        public LabelInfo[] Labels
        {
            get
            {
                return this.labelsField;
            }
            set
            {
                this.labelsField = value;
            }
        }

        
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "extraartists")]
        [System.Xml.Serialization.XmlArrayItemAttribute("artist")]
        public ArtistInfo[] ExtraArtists
        {
            get
            {
                return this.extraartistsField;
            }
            set
            {
                this.extraartistsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "formats")]
        [System.Xml.Serialization.XmlArrayItemAttribute("format")]
        public FormatInfo[] Formats
        {
            get
            {
                return this.formatsField;
            }
            set
            {
                this.formatsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "genres")]
        [System.Xml.Serialization.XmlArrayItemAttribute("genre")]
        public string[] Genres
        {
            get
            {
                return this.genresField;
            }
            set
            {
                this.genresField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "styles")]
        [System.Xml.Serialization.XmlArrayItemAttribute("style")]
        public string[] Styles
        {
            get
            {
                return this.stylesField;
            }
            set
            {
                this.stylesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(ElementName="tracklist")]
        [System.Xml.Serialization.XmlArrayItemAttribute("track")]
        public TrackInfo[] TrackList
        {
            get
            {
                return this.tracklistField;
            }
            set
            {
                this.tracklistField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("country")]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("released")]
        public string Released
        {
            get
            {
                return this.releasedField;
            }
            set
            {
                this.releasedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("notes")]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "id")]
        public int ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "status")]
        public ReleaseStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

    }
}
