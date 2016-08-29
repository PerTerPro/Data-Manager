using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Websosanh.SearchEngines.SolrDriverTypes;

namespace Websosanh.SearchEngines
{
    public class SolrDriverUtils
    {
        public static string GetFilterIdField(int propertyId)
        {
            return string.Format("{0}{1}_id", SolrDriverConstants.PREFIX_INT_FILTER_FIELD,propertyId); //SolrDriverConstants.PREFIX_INT_FILTER_FIELD + filterPropertiesID + "_id"
        }

        public static string GetFilterIdKey(int propertyId)
        {
            return string.Format("{0}_id", propertyId); //SolrDriverConstants.PREFIX_INT_FILTER_FIELD + filterPropertiesID + "_id"
        }

        public static string GetFilterValueField(int propertyId, FieldType fieldType)
        {
            switch (fieldType)
            {
                case FieldType.Int:
                    return string.Format("{0}{1}", SolrDriverConstants.PREFIX_INT_FILTER_FIELD, propertyId);
                    break;
                case FieldType.Double:
                    return string.Format("{0}{1}", SolrDriverConstants.PREFIX_DOUBLE_FILTER_FIELD, propertyId);
                    break;
                case FieldType.DateTime:
                    return string.Format("{0}{1}", SolrDriverConstants.PREFIX_DATETIME_FILTER_FIELD, propertyId);
                    break;
                default:
                    return string.Format("{0}{1}", SolrDriverConstants.PREFIX_STRING_FILTER_FIELD, propertyId);
                    break;
            }
        }
        public static string GetFilterValueKey(int propertyId, FieldType fieldType)
        {
            switch (fieldType)
            {
                case FieldType.Int:
                    return string.Format("{0}", propertyId);
                    break;
                case FieldType.Double:
                    return string.Format("{0}", propertyId);
                    break;
                case FieldType.DateTime:
                    return string.Format("{0}", propertyId);
                    break;
                default:
                    return string.Format("{0}", propertyId);
                    break;
            }
        }
    }
}
