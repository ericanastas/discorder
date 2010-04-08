using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    public class Search
    {

        public int LastPageNum { get; private set; }
        private Dictionary<int, List<SearchResult>> _cachedResults = new Dictionary<int, List<SearchResult>>();
        private SearchType _searchType;
        private string _searchQuery;
        public int TotalResults { get; set; }

        public List<SearchResult> GetSearchResults(int page)
        {
            if (page < 1 | page > LastPageNum) throw new IndexOutOfRangeException("page must be between 1 and LastPageNum");

            if (this._cachedResults.Keys.Contains(page))
            {
                return this._cachedResults[page];
            }
            else
            {
                this.CacheResults(page);

                return this._cachedResults[page];
            }
        }

        private SearchResultList CacheResults(int page)
        {
            SearchResultList list;
            SearchResultList exList;

            Discogs.Search(this._searchQuery, this._searchType, page, out list, out exList);

            this._cachedResults.Remove(page);
            this._cachedResults.Add(page, new List<SearchResult>(list.Results));

            return list;
        }

        public Search(string query, SearchType type)
        {
            this._searchType = type;
            this._searchQuery = query;

            SearchResultList page1res = this.CacheResults(1);
            this.TotalResults = page1res.numResults;
            this.LastPageNum = page1res.numResults / 20 + 1;
        }
    }
}
