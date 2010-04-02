using System.Xml.Serialization;

namespace Discorder.REST {

       

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public class resp {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private ResponseStatus statField;
        
        private float versionField;
        
        private int requestsField;
        
        private bool requestsFieldSpecified;



        [System.Xml.Serialization.XmlElementAttribute("artist", typeof(ArtistDetails))]
        [System.Xml.Serialization.XmlElementAttribute("exactresults", typeof(SearchResultList))]
        //[System.Xml.Serialization.XmlElementAttribute("label", typeof(LabelDetails))]
        //[System.Xml.Serialization.XmlElementAttribute("release", typeof(ReleaseDetails))]
        //[System.Xml.Serialization.XmlElementAttribute("searchresults", typeof(SearchResultList))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResponseStatus stat
        {
            get
            {
                return this.statField;
            }
            set
            {
                this.statField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int requests
        {
            get
            {
                return this.requestsField;
            }
            set
            {
                this.requestsField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestsSpecified
        {
            get
            {
                return this.requestsFieldSpecified;
            }
            set
            {
                this.requestsFieldSpecified = value;
            }
        }
    }
    

}
