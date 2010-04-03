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
        //http://www.discogs.com/artist/Aphex+Twin?f=xml&api_key=<API_Key>  



        public static string ApiKey = "7ccd6b4264";

        public static Discorder.REST.ReleaseDetails GetRelease(int releaseID)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = "www.discogs.com";
            builder.Path = @"release/" + releaseID.ToString();
            builder.Query = "f=xml&apikey=" + ApiKey;
            REST.Response r = GetResponse(builder.Uri.ToString());
            return r.Release;
        }


        public static Discorder.REST.ArtistDetails GetArtist(string artistName)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = "www.discogs.com";
            builder.Path = @"artist/" + System.Uri.EscapeDataString(artistName);
            builder.Query = "f=xml&apikey=" + ApiKey;
            REST.Response r = GetResponse(builder.Uri.ToString());
            return r.Artist;
        }

        public static Discorder.REST.LabelDetails GetLabel(string labelName)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = "www.discogs.com";
            builder.Path = @"label/" + System.Uri.EscapeDataString(labelName);
            builder.Query = "f=xml&apikey=" + ApiKey;
            REST.Response r = GetResponse(builder.Uri.ToString());
            return r.Label;
        }

        public static void Search(string query, out REST.SearchResultList searchResults, out REST.SearchResultList exactResults)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Host = "www.discogs.com";
            uriBuilder.Path = "search";
            string queryEncoded = "type=all&q=" + System.Uri.EscapeDataString(query) + "&f=xml&api_key=" + ApiKey;
            uriBuilder.Query = queryEncoded;
            REST.Response r = GetResponse(uriBuilder.Uri.ToString());

            exactResults = r.SearchResultsExact;
            searchResults = r.SearchResults;
        }

        private static Discorder.REST.Response GetResponse(string uri)
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
                    extraTypesList.Add(typeof(REST.Response));
                    extraTypesList.Add(typeof(REST.SearchResult));
                    extraTypesList.Add(typeof(REST.SearchResultList));
                    extraTypesList.Add(typeof(REST.TrackInfo));

                    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Discorder.REST.Response));

                    try
                    {
                        Discorder.REST.Response response = (Discorder.REST.Response)xmlSerializer.Deserialize(reader);
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