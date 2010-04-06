using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    class DiscogsSearchVirtualDataSource : BrightIdeasSoftware.IVirtualListDataSource
    {
        #region IVirtualListDataSource Members

        private SearchType _searchType;
        private string _searchQuery;
        private int _numResults = 0;
        private int _numPerPage = 20;


        //caches the returned search result 
        //key is the page number
        private Dictionary<int, SearchResultList> _searchResultListCache = new Dictionary<int, SearchResultList>();


        /// <summary>
        /// Translates an overall index number to the page number that should include it
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int IndexToPageNum(int index)
        {
            int x = ((index) / this._numPerPage) + 1;
            return x;
        }


        /// <summary>
        /// Translates an overall index to the index of the item on the page
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int IndexToPageIndex(int index)
        {
            int pageCount = index / this._numPerPage;
            int x = index - pageCount * this._numPerPage;

            if (x < 0) System.Windows.Forms.MessageBox.Show("blah");
            return x;
        }


        public DiscogsSearchVirtualDataSource(SearchType searchType, string searchQuery)
        {
            if (String.IsNullOrEmpty(searchQuery)) throw new ArgumentException("SearchQuery");
            this._searchQuery = searchQuery;
            this._searchType = searchType;


            SearchResultList res;
            SearchResultList exres;
            Discogs.Search(this._searchQuery, this._searchType, 1, out res, out exres);
            this._numResults = res.numResults;
            this._searchResultListCache.Add(1, res);



        }

        public void AddObjects(System.Collections.ICollection modelObjects)
        {
            //can't add objects
        }

        public object GetNthObject(int n)
        {
            int pagenum = this.IndexToPageNum(n);

            if (!this._searchResultListCache.Keys.Contains<int>(pagenum))
            {
                CachePage(pagenum);
            }


            SearchResultList result = this._searchResultListCache[pagenum];
            int Resultindx = this.IndexToPageIndex(n);
            return result.Results[Resultindx];





        }

        public int GetObjectCount()
        {
            return this._numResults;
        }


        public int GetObjectIndex(object model)
        {
            SearchResult r = (SearchResult)model;
            return r.num - 1;
        }



        public void PrepareCache(int first, int last)
        {
            List<int> requiredPages = new List<int>();
            int pageNum;

            for (int i = first; i <= last; i++)
            {
                pageNum = this.IndexToPageNum(i);
                if (!requiredPages.Contains(pageNum)) requiredPages.Add(pageNum);
            }


            foreach (int page in requiredPages)
            {
                if (!this._searchResultListCache.Keys.Contains<int>(page))
                {
                    this.CachePage(page);
                }
            }
        }

        private void CachePage(int page)
        {
            SearchResultList res;
            SearchResultList exres;
            Discogs.Search(this._searchQuery, this._searchType, page, out res, out exres);
            this._searchResultListCache.Add(page, res);
        }

        public void RemoveObjects(System.Collections.ICollection modelObjects)
        {
            //can't remove objects
        }

        public int SearchText(string value, int first, int last, BrightIdeasSoftware.OLVColumn column)
        {
            //can't search
            return 0;
        }

        public void SetObjects(System.Collections.IEnumerable collection)
        {
            //can't set objets
        }

        public void Sort(BrightIdeasSoftware.OLVColumn column, System.Windows.Forms.SortOrder order)
        {
            //sort now allowed
        }

        #endregion


    }
}
