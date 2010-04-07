using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class ReleaseInfo
    {

        private string catnoField;
        private string artistField;
        private string titleField;
        private string trackinfoField;
        private string formatField;
        private string labelField;
        private int yearField;
        private int idField;
        private ReleaseStatus statusField;
        private ReleaseType typeField;


        [System.Xml.Serialization.XmlElementAttribute("catno")]
        public string CatalogNumber
        {
            get
            {
                return this.catnoField;
            }
            set
            {
                this.catnoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("artist")]
        public string Artist
        {
            get
            {
                return this.artistField;
            }
            set
            {
                this.artistField = value;
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

        [System.Xml.Serialization.XmlElementAttribute("trackinfo")]
        public string TrackInfo
        {
            get
            {
                return this.trackinfoField;
            }
            set
            {
                this.trackinfoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("format")]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("label")]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("year")]
        public int Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }



        
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
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



        
        [System.Xml.Serialization.XmlAttributeAttribute("status")]
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

        
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public ReleaseType ReleaseType
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }


    }
}
