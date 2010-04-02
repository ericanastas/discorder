using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class ImageInfo
    {

        private int heightField;

        private ImageType typeField;

        private string uriField;

        private string uri150Field;

        private int widthField;


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ImageType type
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


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri150
        {
            get
            {
                return this.uri150Field;
            }
            set
            {
                this.uri150Field = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }
}
