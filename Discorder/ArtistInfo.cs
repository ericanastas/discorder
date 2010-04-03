using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class ArtistInfo
    {
        private string nameField;
        private string anvField;
        private string roleField;
        private string tracksField;
        private string joinField;

        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("anv")]
        public string anv
        {
            get
            {
                return this.anvField;
            }
            set
            {
                this.anvField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("role")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("tracks")]
        public string tracks
        {
            get
            {
                return this.tracksField;
            }
            set
            {
                this.tracksField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("join")]
        public string Join
        {
            get
            {
                return this.joinField;
            }
            set
            {
                this.joinField = value;
            }
        }
    }
}
