using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class LabelDetails
    {

        private ImageInfo[] imagesField;

        private string nameField;

        private string contactinfoField;

        private string profileField;

        private string parentLabelField;

        private string[] urlsField;

        private string[] sublabelsField;

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

        
        public string contactinfo
        {
            get
            {
                return this.contactinfoField;
            }
            set
            {
                this.contactinfoField = value;
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

        
        public string parentLabel
        {
            get
            {
                return this.parentLabelField;
            }
            set
            {
                this.parentLabelField = value;
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

        
        [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable = false)]
        public string[] sublabels
        {
            get
            {
                return this.sublabelsField;
            }
            set
            {
                this.sublabelsField = value;
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
