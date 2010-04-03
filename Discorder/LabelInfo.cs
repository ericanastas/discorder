using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class LabelInfo
    {
        private string catnoField;
        private string nameField;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "catno")]
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="name")]
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
    }
}
