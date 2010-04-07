using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{

    [System.SerializableAttribute()]
    public enum ResponseStatus
    {
        ok,
        error,
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
        UnofficialRelease
    }

    [System.SerializableAttribute()]
    public enum ReleaseStatus
    {
        Accepted,
        Draft,
        Rejected
    }

    public enum SearchType
    {
        all,
        artists,
        labels,
        releases,
        catno,
        needsvote,
        forsale,
        digital
    }

    [System.SerializableAttribute()]
    public enum SearchResultType
    {

        artist,

        label,

        release


    }

    [System.SerializableAttribute()]
    public enum FormatName
    {
        [System.Xml.Serialization.XmlEnumAttribute("Box Set")]
        BoxSet,
        Cassette,
        CD,
        CDr,
        File,
        Vinyl,
        DVD,
        VHS,
        DVDr,
        Shellac,
        Acetate
    }

    [System.SerializableAttribute()]
    public enum ImageType
    {
        primary,
        secondary
    }

}
