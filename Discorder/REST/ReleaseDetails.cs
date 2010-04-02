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

        private bool statusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public ImageInfo[] images
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable = false)]
        public ArtistInfo[] artists
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

        /// <remarks/>
        public string title
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable = false)]
        public LabelInfo[] labels
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable = false)]
        public ArtistInfo[] extraartists
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("format", IsNullable = false)]
        public FormatInfo[] formats
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("genre", IsNullable = false)]
        public string[] genres
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("style", IsNullable = false)]
        public string[] styles
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

        /// <remarks/>
        public string country
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

        /// <remarks/>
        public string released
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

        /// <remarks/>
        public string notes
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("track", IsNullable = false)]
        public TrackInfo[] tracklist
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReleaseStatus status
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
    }
}
