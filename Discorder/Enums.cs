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
        Vinyl,
        Acetate,
        [System.Xml.Serialization.XmlEnumAttribute("Flexi-disc")]
        Flexidisc,
        [System.Xml.Serialization.XmlEnumAttribute("Lathe Cut")]
        LatheCut,
        Shellac,
        Cylinder,
        CD,
        CDr,
        CDV,
        DVD,
        DVDr,
        [System.Xml.Serialization.XmlEnumAttribute("HD DVD")]
        HDDVD,
        [System.Xml.Serialization.XmlEnumAttribute("HD DVD-R")]
        HDDVDR,
        [System.Xml.Serialization.XmlEnumAttribute("Blu-ray")]
        Bluray,
        [System.Xml.Serialization.XmlEnumAttribute("Blu-ray-R")]
        BlurayR,
        [System.Xml.Serialization.XmlEnumAttribute("8-Track Cartridge")]
        EightTrackCartridge,
        Cassette,
        DAT,
        DCC,
        Microcassette,
        [System.Xml.Serialization.XmlEnumAttribute("Reel-To-Reel")]
        ReelToReel,
        Betamax,
        VHS,
        [System.Xml.Serialization.XmlEnumAttribute("Video 2000")]
        Video2000,
        Laserdisc,
        SelectaVision,
        Minidisc,
        MVD,
        UMD,
        Datassette,
        [System.Xml.Serialization.XmlEnumAttribute("Floppy Disk")]
        FloppyDisk,
        File,
        [System.Xml.Serialization.XmlEnumAttribute("Memory Stick")]
        MemoryStick,
        Hybrid,

        [System.Xml.Serialization.XmlEnumAttribute("All Media")]
        AllMedia,

        [System.Xml.Serialization.XmlEnumAttribute("Box Set")]
        BoxSet
    }

    [System.SerializableAttribute()]
    public enum ImageType
    {
        primary,
        secondary
    }

}
