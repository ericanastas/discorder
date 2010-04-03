using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class FormatInfo
    {
        private string[] descriptionsField;
        private FormatName nameField;
        private int qtyField;

        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "descriptions")]
        [System.Xml.Serialization.XmlArrayItemAttribute("description")]        
        public string[] Descriptions
        {
            get
            {
                return this.descriptionsField;
            }
            set
            {
                this.descriptionsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="name")]
        public FormatName Name
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="qty")]
        public int Quanity
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }
}
