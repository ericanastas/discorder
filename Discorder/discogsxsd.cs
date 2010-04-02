using System.Xml.Serialization;

namespace Discorder {

       

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
    

    [System.SerializableAttribute()]
    public class ArtistDetails {
        
        private ImageInfo[] imagesField;
        
        private string nameField;
        
        private string realnameField;
        
        private string profileField;
        
        private string[] urlsField;
        
        private string[] namevariationsField;
        
        private string[] aliasesField;
        
        private string[] groupsField;
        
        private string[] membersField;
        
        private ReleaseInfo[] releasesField;
        
     
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable=false)]
        public ImageInfo[] images {
            get {
                return this.imagesField;
            }
            set {
                this.imagesField = value;
            }
        }
        
 
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
   
        public string realname {
            get {
                return this.realnameField;
            }
            set {
                this.realnameField = value;
            }
        }
        
     
        public string profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        

        [System.Xml.Serialization.XmlArrayItemAttribute("url", IsNullable=false)]
        public string[] urls {
            get {
                return this.urlsField;
            }
            set {
                this.urlsField = value;
            }
        }
        
 
        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable=false)]
        public string[] namevariations {
            get {
                return this.namevariationsField;
            }
            set {
                this.namevariationsField = value;
            }
        }
        

        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable=false)]
        public string[] aliases {
            get {
                return this.aliasesField;
            }
            set {
                this.aliasesField = value;
            }
        }
        

        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable=false)]
        public string[] groups {
            get {
                return this.groupsField;
            }
            set {
                this.groupsField = value;
            }
        }
        

        [System.Xml.Serialization.XmlArrayItemAttribute("name", IsNullable=false)]
        public string[] members {
            get {
                return this.membersField;
            }
            set {
                this.membersField = value;
            }
        }
        

        [System.Xml.Serialization.XmlArrayItemAttribute("release", IsNullable=false)]
        public ReleaseInfo[] releases {
            get {
                return this.releasesField;
            }
            set {
                this.releasesField = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public class ImageInfo {
        
        private int heightField;
        
        private ImageType typeField;
        
        private string uriField;
        
        private string uri150Field;
        
        private int widthField;
        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ImageType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri150 {
            get {
                return this.uri150Field;
            }
            set {
                this.uri150Field = value;
            }
        }
        

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
    }
    

    [System.SerializableAttribute()]
    public enum ImageType {


        primary,
        

        secondary,
    }
    


    [System.SerializableAttribute()]

    public class SearchResult {
        
        private string titleField;
        
        private string anvField;
        
        private string uriField;
        
        private string summaryField;
        
        private int numField;
        
        private bool numFieldSpecified;
        
        private SearchResultType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string anv {
            get {
                return this.anvField;
            }
            set {
                this.anvField = value;
            }
        }
        
        /// <remarks/>
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
        
        /// <remarks/>
        public string summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int num {
            get {
                return this.numField;
            }
            set {
                this.numField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numSpecified {
            get {
                return this.numFieldSpecified;
            }
            set {
                this.numFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchResultType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
    }
    


    [System.SerializableAttribute()]
    public enum SearchResultType {
        
        artist,
        
        label,
        
        release,
    }
    

    [System.SerializableAttribute()]
    public class SearchResultList {
        
        private SearchResult[] resultField;
        private int endField;
        private int numResultsField;
        private int startField;
        
        [System.Xml.Serialization.XmlElementAttribute("result")]
        public SearchResult[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numResults {
            get {
                return this.numResultsField;
            }
            set {
                this.numResultsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
    }
    

    [System.SerializableAttribute()]
    public class TrackInfo {
        
        private string positionField;
        
        private ArtistInfo[] artistsField;
        
        private string titleField;
        
        private ArtistInfo[] extraartistsField;
        
        private string durationField;
        
        /// <remarks/>
        public string position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable=false)]
        public ArtistInfo[] artists {
            get {
                return this.artistsField;
            }
            set {
                this.artistsField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable=false)]
        public ArtistInfo[] extraartists {
            get {
                return this.extraartistsField;
            }
            set {
                this.extraartistsField = value;
            }
        }
        
        /// <remarks/>
        public string duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
    }
    

    [System.SerializableAttribute()]
    public class ArtistInfo {
        
        private string nameField;
        
        private string anvField;
        
        private string roleField;
        
        private string tracksField;
        
        private string joinField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string anv {
            get {
                return this.anvField;
            }
            set {
                this.anvField = value;
            }
        }
        
        /// <remarks/>
        public string role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string tracks {
            get {
                return this.tracksField;
            }
            set {
                this.tracksField = value;
            }
        }
        
        /// <remarks/>
        public string join {
            get {
                return this.joinField;
            }
            set {
                this.joinField = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public class FormatInfo {
        
        private string[][] descriptionsField;
        
        private FormatName nameField;
        
        private int qtyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("description", typeof(string), IsNullable=false)]
        public string[][] descriptions {
            get {
                return this.descriptionsField;
            }
            set {
                this.descriptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FormatName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public enum FormatName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Box Set")]
        BoxSet,
        
        /// <remarks/>
        Cassette,
        
        /// <remarks/>
        CD,
        
        /// <remarks/>
        File,
        
        /// <remarks/>
        Vinyl,
    }
    
    
    
    [System.SerializableAttribute()]
    public class LabelInfo {
        
        private string catnoField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string catno {
            get {
                return this.catnoField;
            }
            set {
                this.catnoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public class ReleaseDetails {
        
        private ImageInfo[] imagesField;
        
        private ArtistInfo[] artistsField;
        
        private string titleField;
        
        private LabelInfo[] labelsField;
        
        private ArtistInfo[] extraartistsField;
        
        private FormatInfo[] formatsField;
        
        private string[] genresField;
        
        private string[] stylesField;
        
        private string countryField;
        
        private string releasedField;
        
        private string notesField;
        
        private TrackInfo[] tracklistField;
        
        private int idField;
        
        private ReleaseStatus statusField;
        
        private bool statusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable=false)]
        public ImageInfo[] images {
            get {
                return this.imagesField;
            }
            set {
                this.imagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable=false)]
        public ArtistInfo[] artists {
            get {
                return this.artistsField;
            }
            set {
                this.artistsField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable=false)]
        public LabelInfo[] labels {
            get {
                return this.labelsField;
            }
            set {
                this.labelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artist", IsNullable=false)]
        public ArtistInfo[] extraartists {
            get {
                return this.extraartistsField;
            }
            set {
                this.extraartistsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("format", IsNullable=false)]
        public FormatInfo[] formats {
            get {
                return this.formatsField;
            }
            set {
                this.formatsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("genre", IsNullable=false)]
        public string[] genres {
            get {
                return this.genresField;
            }
            set {
                this.genresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("style", IsNullable=false)]
        public string[] styles {
            get {
                return this.stylesField;
            }
            set {
                this.stylesField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string released {
            get {
                return this.releasedField;
            }
            set {
                this.releasedField = value;
            }
        }
        
        /// <remarks/>
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("track", IsNullable=false)]
        public TrackInfo[] tracklist {
            get {
                return this.tracklistField;
            }
            set {
                this.tracklistField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReleaseStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public enum ReleaseStatus {
        
        /// <remarks/>
        Accepted,
        
        /// <remarks/>
        Draft,
        
        /// <remarks/>
        Rejected,
    }
    
    
    
    [System.SerializableAttribute()]
    public class LabelDetails {
        
        private ImageInfo[] imagesField;
        
        private string nameField;
        
        private string contactinfoField;
        
        private string profileField;
        
        private string parentLabelField;
        
        private string[] urlsField;
        
        private string[] sublabelsField;
        
        private ReleaseInfo[] releasesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable=false)]
        public ImageInfo[] images {
            get {
                return this.imagesField;
            }
            set {
                this.imagesField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string contactinfo {
            get {
                return this.contactinfoField;
            }
            set {
                this.contactinfoField = value;
            }
        }
        
        /// <remarks/>
        public string profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        
        /// <remarks/>
        public string parentLabel {
            get {
                return this.parentLabelField;
            }
            set {
                this.parentLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("url", IsNullable=false)]
        public string[] urls {
            get {
                return this.urlsField;
            }
            set {
                this.urlsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable=false)]
        public string[] sublabels {
            get {
                return this.sublabelsField;
            }
            set {
                this.sublabelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("release", IsNullable=false)]
        public ReleaseInfo[] releases {
            get {
                return this.releasesField;
            }
            set {
                this.releasesField = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public class ReleaseInfo {
        
        private string catnoField;
        
        private string artistField;
        
        private string titleField;
        
        private string trackinfoField;
        
        private string formatField;
        
        private string labelField;
        
        private int yearField;
        
        private bool yearFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private ReleaseStatus statusField;
        
        private bool statusFieldSpecified;
        
        private ReleaseType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        public string catno {
            get {
                return this.catnoField;
            }
            set {
                this.catnoField = value;
            }
        }
        
        /// <remarks/>
        public string artist {
            get {
                return this.artistField;
            }
            set {
                this.artistField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string trackinfo {
            get {
                return this.trackinfoField;
            }
            set {
                this.trackinfoField = value;
            }
        }
        
        /// <remarks/>
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        public int year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearSpecified {
            get {
                return this.yearFieldSpecified;
            }
            set {
                this.yearFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReleaseStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReleaseType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
    }
    
    
    
    [System.SerializableAttribute()]
    public enum ReleaseType {
        
        
        Appearance,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("Co-producer")]
        Coproducer,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("DJ Mix")]
        DJMix,
        
        
        Main,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("Mixed by")]
        Mixedby,
        
        
        Producer,
        
        
        Remix,
        
        
        TrackAppearance,
        
        
        UnofficialRelease,
    }
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        
        artist,
        
        
        exactresults,
        
        
        label,
        
        
        release,
        
        
        searchresults,
    }
    
    
    
    [System.SerializableAttribute()]
    public enum ResponseStatus {
        
        
        ok,
        
        
        error,
    }
}
