using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Websosanh.SearchEngines
{
    public static class SolrDriverConstants
    {
        public const string PREFIX_INT_FILTER_FIELD = "filter_int_";
        public const string PREFIX_DOUBLE_FILTER_FIELD = "filter_double_";
        public const string PREFIX_STRING_FILTER_FIELD = "filter_string_";
        public const string PREFIX_DATETIME_FILTER_FIELD = "filter_datetime_";
        public const string PREFIX_SORT_COMPONENT = "sort-";
        public const string PREFIX_FILTER_COMPONENT = "filter-";
        public const string SEPARATED_FILTER_VALUES = "v";
        public const string SEPARATED_FILTER_RANGE = "~";
        public const string SEPARATED_SORT_COMPONENT = "-";
        public const string SEPARATED_FILTER_COMPONENTS = "_";
        public const string SEPARATED_FILTER_AND_SORT = "__";

    }
}
