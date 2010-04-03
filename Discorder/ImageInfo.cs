using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class ImageInfo
    {
        private int heightField;
        private ImageType typeField;
        private string uriField;
        private string uri150Field;
        private int widthField;


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="height")]
        public int Height
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


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        public ImageType Type
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


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "uri")]
        public string URI
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


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "uri150")]
        public string URI150
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


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "width")]
        public int Width
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
