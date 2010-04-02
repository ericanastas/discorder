using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class ArtistDetails
    {

        private ImageInfo[] imagesField;

        private string nameField;

        private string realnameField;

        private string profileField;

        private string[] urlsField;

        private string[] namevariationsField;

        private string[] aliasesField;

        private string[] groupsField;

        private string[] membersField;

        private ReleaseInfo[] releasesField;


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


        public string name
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


        public string realname
        {
            get
            {
                return this.realnameField;
            }
            set
            {
                this.realnameField = value;
            }
        }


        public string profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("url", IsNullable = false)]
        public string[] urls
        {
            get
            {
                return this.urlsField;
            }
            set
            {
                this.urlsField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable = false)]
        public string[] namevariations
        {
            get
            {
                return this.namevariationsField;
            }
            set
            {
                this.namevariationsField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable = false)]
        public string[] aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable = false)]
        public string[] groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable = false)]
        public string[] members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("release", IsNullable = false)]
        public ReleaseInfo[] releases
        {
            get
            {
                return this.releasesField;
            }
            set
            {
                this.releasesField = value;
            }
        }
    }
    
}
