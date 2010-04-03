using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class SearchResultList
    {

        private SearchResult[] resultField;
        private int endField;
        private int numResultsField;
        private int startField;

        [System.Xml.Serialization.XmlElementAttribute("result")]
        public SearchResult[] Results
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numResults
        {
            get
            {
                return this.numResultsField;
            }
            set
            {
                this.numResultsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }

}
