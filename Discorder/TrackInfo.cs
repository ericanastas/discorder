using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{

    [System.SerializableAttribute()]
    public class TrackInfo
    {

        private string positionField;

        private ArtistInfo[] artistsField;

        private string titleField;

        private ArtistInfo[] extraartistsField;

        private string durationField;

        /// <remarks/>
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
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
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }
    
}
