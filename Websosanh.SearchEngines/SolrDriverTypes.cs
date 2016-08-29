using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Websosanh.SearchEngines
{
    namespace SolrDriverTypes
    {
        public enum SortCategory
        {
            SortByPriceIncrease = 1,
            SortByPriceDescrease = 2,
            SortByViewCount = 3,
        };

        public enum FieldType
        {
            Int = 1,
            Double = 2,
            String = 3,
            DateTime = 4
        };

        public enum SortOrderType
        {
            Asc = 1,
            Desc = 2
        }

        public class SortField
        {
            public string FieldId { get; set; }
            public FieldType FieldType { get; set; }
            public SortOrderType SortOrderType { get; set; }
        }

        public enum FacetSortType
        {
            Count = 1,
            Index = 2
        }

        public class FacetFieldQuery
        {
            public string Field { get; set; }
            public List<double> Range { get; set; }
            public int Limit { get; set; }
            public int MinCount { get; set; }
            public FacetSortType SortType { get; set; }
            public List<KeyValuePair<string, int>> Result;
            public FacetFieldQuery()
            {
                Limit = -1;
                MinCount = 0;
                SortType = FacetSortType.Index;
                Result = new List<KeyValuePair<string, int>>();
            }

        }
    }
}
