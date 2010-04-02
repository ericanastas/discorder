using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{

    [System.SerializableAttribute()]
    public enum ResponseStatus
    {


        ok,


        error,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {


        artist,


        exactresults,


        label,


        release,


        searchresults,
    }

    [System.SerializableAttribute()]
    public enum ReleaseType
    {


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
    public enum ReleaseStatus
    {

        /// <remarks/>
        Accepted,

        /// <remarks/>
        Draft,

        /// <remarks/>
        Rejected,
    }

    [System.SerializableAttribute()]
    public enum SearchResultType
    {

        artist,

        label,

        release,
    }

    [System.SerializableAttribute()]
    public enum FormatName
    {

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

}
