using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.Discogs
{
    public class DiscogSite
    {
        //http://www.discogs.com/artist/Bob?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/label/Svek?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/release/58168?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/releas/58168?f=xml&api_key=7ccd6b4264
        //http://www.discogs.com/search?type=all&q=deep+house&f=xml&api_key=7ccd6b4264
          
        public static string ApiKey = "7ccd6b4264";

        static Release GetRelease(int releaseID)
        {
            //returns a single release
            return null;
        }

        //http://www.discogs.com/artist/Aphex+Twin?f=xml&api_key=<API_Key>  
        static Artist GetArtist(string artistName)
        {
            //return single artist

            return null;
        }


        static Label GetLabel(string labelName)
        {
            //returns a single label
            return null;
        }


        
        static List<SearchResult> Search(string searchQuery, string type)
        {
            //search results
            return null;
        }

    }
}
