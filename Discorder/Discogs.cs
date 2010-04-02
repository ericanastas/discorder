using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace Discorder
{
    public class DiscogSite
    {
        //http://www.discogs.com/artist/Bob?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/label/Svek?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/release/58168?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/releas/58168?f=xml&api_key=7ccd6b4264


        public static string ApiKey = "7ccd6b4264";


        public static Discorder.REST.ReleaseDetails GetRelease(int releaseID)
        {
            //returns a single release
            return null;
        }

        //http://www.discogs.com/artist/Aphex+Twin?f=xml&api_key=<API_Key>  
        public static Discorder.REST.ArtistDetails GetArtist(string artistName)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = "www.discogs.com";
            builder.Path = @"artist/" + System.Uri.EscapeDataString(artistName);
            builder.Query = "f=xml&apikey=" + ApiKey;


            GetResponse(builder.Uri.ToString());

            return null;
        }


        public static Discorder.REST.LabelDetails GetLabel(string labelName)
        {
            //returns a single label
            return null;
        }


        public static List<REST.ArtistDetails> SearchArtist(string query)
        {


            return new List<REST.ArtistDetails>(SearchByType(query, REST.SearchResultType.artist).Cast<REST.ArtistDetails>());
        }


        public static List<REST.LabelDetails> SearchLabel(string query)
        {
            return new List<REST.LabelDetails>(SearchByType(query, REST.SearchResultType.label).Cast<REST.LabelDetails>());

        }

        public static List<REST.ReleaseDetails> SearchRelease(string query)
        {


            return new List<REST.ReleaseDetails>(SearchByType(query, REST.SearchResultType.release).Cast<REST.ReleaseDetails>());

        }

        private static List<Object> SearchByType(string searchQuery, REST.SearchResultType type)
        {


            throw new NotSupportedException("The type parameter of the Discogs REST api doesn't seem to do anything yet");

            //http://www.discogs.com/search?type=all&q=deep+house&f=xml&api_key=7ccd6b4264



        }

        public static List<Object> Search(string query)
        {

            UriBuilder uriBuilder = new UriBuilder();



            string queryEncoded = "type=all&q=" + System.Uri.EscapeDataString(query) + "&f=xml&api_key=" + ApiKey;

            uriBuilder.Host = "www.discogs.com";
            uriBuilder.Path = "search";
            uriBuilder.Query = queryEncoded;


            Discorder.REST.resp r = GetResponse(uriBuilder.Uri.ToString());

            return new List<object>();
        }





        public static System.Xml.XmlDocument GetXmlResponse(string uri)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip");
            wc.Proxy = null;


            using (GZipStream stream = new GZipStream(
               wc.OpenRead(uri), CompressionMode.Decompress, false))
            {
                using (System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(stream))
                {
                    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    xmlDoc.Load(xmlReader);

                    return xmlDoc;
                }
            }



        }


        private static Discorder.REST.resp GetResponse(string uri)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip");
            wc.Proxy = null;


            using (GZipStream stream = new GZipStream(
               wc.OpenRead(uri), CompressionMode.Decompress, false))
            {
                using (StreamReader reader = new StreamReader(stream))
                {



                    List<Type> extraTypesList = new List<Type>();

                    extraTypesList.Add(typeof(REST.ArtistDetails));
                    extraTypesList.Add(typeof(REST.ArtistInfo));
                    extraTypesList.Add(typeof(REST.FormatInfo));
                    extraTypesList.Add(typeof(REST.ImageInfo));
                    extraTypesList.Add(typeof(REST.LabelInfo));
                    extraTypesList.Add(typeof(REST.ReleaseDetails));
                    extraTypesList.Add(typeof(REST.ReleaseInfo));
                    extraTypesList.Add(typeof(REST.resp));
                    extraTypesList.Add(typeof(REST.SearchResult));
                    extraTypesList.Add(typeof(REST.SearchResultList));
                    extraTypesList.Add(typeof(REST.TrackInfo));

                    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Discorder.REST.resp));

                    try
                    {
                        Discorder.REST.resp response = (Discorder.REST.resp)xmlSerializer.Deserialize(reader);
                        return response;
                    }
                    catch (InvalidOperationException exp)
                    {

                        throw;
                    }


                }
            }




        }

    }
}