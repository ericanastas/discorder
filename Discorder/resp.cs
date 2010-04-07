using System.Xml.Serialization;

namespace Discorder
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "resp")]
    public class Response
    {
        private ArtistDetails artistdetailsField;
        private ReleaseDetails releaseDetailsField;
        private LabelDetails labeldetailsField;
        private SearchResultList searchResultsExact;
        private SearchResultList searchResults;
        private ResponseStatus statField;
        private float versionField;
        private int requestsField;

        [System.Xml.Serialization.XmlElementAttribute("exactresults", typeof(SearchResultList))]
        public SearchResultList SearchResultsExact
        {
            get
            {
                return this.searchResultsExact;
            }
            set
            {
                this.searchResultsExact = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("error", typeof(Error))]
        public Error Error
        {
            get;
            set;
        }

        [System.Xml.Serialization.XmlElementAttribute("searchresults", typeof(SearchResultList))]
        public SearchResultList SearchResults
        {
            get
            {
                return this.searchResults;
            }
            set
            {
                this.searchResults = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("label", typeof(LabelDetails))]
        public LabelDetails Label
        {
            get
            {
                return this.labeldetailsField;
            }
            set
            {
                this.labeldetailsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("release", typeof(ReleaseDetails))]
        public ReleaseDetails Release
        {
            get
            {
                return this.releaseDetailsField;
            }
            set
            {
                this.releaseDetailsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("artist", typeof(ArtistDetails))]
        public ArtistDetails Artist
        {
            get
            {
                return this.artistdetailsField;
            }
            set
            {
                this.artistdetailsField = value;
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

    }
}
