using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]

    public class SearchResult
    {
        private string titleField;
        private string anvField;
        private string uriField;
        private string summaryField;
        private int numField;
        private bool numFieldSpecified;
        private SearchResultType typeField;

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

        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int num
        {
            get
            {
                return this.numField;
            }
            set
            {
                this.numField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numSpecified
        {
            get
            {
                return this.numFieldSpecified;
            }
            set
            {
                this.numFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchResultType type
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
