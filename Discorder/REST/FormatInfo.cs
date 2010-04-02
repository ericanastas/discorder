using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class FormatInfo
    {

        private string[][] descriptionsField;

        private FormatName nameField;

        private int qtyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("description", typeof(string), IsNullable = false)]
        public string[][] descriptions
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FormatName name
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int qty
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
