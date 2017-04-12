using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UpdateSolrTools.CompanyDataSetTableAdapters;
using UpdateSolrTools.ProductDatasetTableAdapters;
using Websosanh.Core.Merchant.BO;
using Websosanh.Core.Product.BAL;

namespace UpdateSolrTools
{
    public class IndexProductTools
    {

        public static Dictionary<int, string[]> GetAllCategoryTags(string productConnectionString)
        {
            var result = new Dictionary<int, string[]>();
            var tagCategoryTableAdapter = new Tag_CategoryTableAdapter
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var tagCategoryDataTable = tagCategoryTableAdapter.GetAllCategoryTag();
            for (var rowIndex = 0; rowIndex < tagCategoryDataTable.Rows.Count; rowIndex++)
            {
                int categoryID = tagCategoryDataTable[rowIndex].CategoryID;
                var tags = tagCategoryDataTable[rowIndex].Tag.Split('|');
                result.Add(categoryID, tags);
            }
            return result;
        }
        public static HashSet<long> GetListMerchantUseDatafeedID(string productConnectionString)
        {
            var listIDCompanyUseDatafeed = new HashSet<long>();
            var adtCompanyManagerType = new ManagerTypeRCompanyTableAdapter()
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var companyManagerTypeDataTable = adtCompanyManagerType.GetListMerchantUseDatafeed();
            for (var rowIndex = 0; rowIndex < companyManagerTypeDataTable.Rows.Count; rowIndex++)
            {
                var companyID = companyManagerTypeDataTable[rowIndex].IDCompany;
                if (!listIDCompanyUseDatafeed.Contains(companyID))
                    listIDCompanyUseDatafeed.Add(companyID);
            }
            return listIDCompanyUseDatafeed;
        }

        public static HashSet<long> GetListSpecialMerchantID(string productConnectionString)
        {
            var listSpecialMerchantID = new HashSet<long>();
            var adtCompanyManagerType = new ManagerTypeRCompanyTableAdapter()
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var companyManagerTypeDataTable = adtCompanyManagerType.GetListSpecialMerchant();
            for (var rowIndex = 0; rowIndex < companyManagerTypeDataTable.Rows.Count; rowIndex++)
            {
                var companyID = companyManagerTypeDataTable[rowIndex].IDCompany;
                if (!listSpecialMerchantID.Contains(companyID))
                    listSpecialMerchantID.Add(companyID);
            }
            //add lazada(3502170206813664485) and adayroi(3433481253691794480)
            //if (!listSpecialMerchantID.Contains(3502170206813664485))
            //    listSpecialMerchantID.Add(3502170206813664485);
            //if (!listSpecialMerchantID.Contains(3433481253691794480))
            //    listSpecialMerchantID.Add(3433481253691794480);
            return listSpecialMerchantID;
        }

        public static Dictionary<int, string> GetAllPrefixCategory(string productConnectionString)
        {
            var result = new Dictionary<int, string>();
            ListClassificationTableAdapter listClassificationTableAdapter = new ListClassificationTableAdapter
            {
                Connection = {ConnectionString = productConnectionString}
            };
            var listClassificationDataTable = listClassificationTableAdapter.GetAllPrefixCategory();
            for (int rowIndex = 0; rowIndex < listClassificationDataTable.Rows.Count; rowIndex++)
            {
                result.Add(listClassificationDataTable[rowIndex].ID, listClassificationDataTable[rowIndex].Name);
            }
            return result;
        }

        public static HashSet<long> GetAllBadMerchantId(string productConnectionString, int scoreThreshold)
        {
            var badMerchantIdSet = new HashSet<long>();
            var merchantScoreTableAdapter = new MerchantScoreTableAdapter
            {
                Connection = new SqlConnection {ConnectionString = productConnectionString}
            };
            var merchantScoreDataTable = merchantScoreTableAdapter.GetAllBadMerchant(scoreThreshold);
            for (int rowIndex = 0; rowIndex < merchantScoreDataTable.Rows.Count; rowIndex++)
            {
                badMerchantIdSet.Add(merchantScoreDataTable[rowIndex].MerchantId);
            }
            //add  Adayroi
            if (!badMerchantIdSet.Contains(3433481253691794480))
                badMerchantIdSet.Add(3433481253691794480);
            return badMerchantIdSet;
        }

        public static Dictionary<long, int> GetAllPriorMerchants(string productConnectionString)
        {
            var allPriorMerchants = new Dictionary<long, int>();
            var priorMerchantTableAdapter = new PriorMerchantTableAdapter()
            {
                Connection = {ConnectionString = productConnectionString}
            };
            var priorMerchantDataTable = priorMerchantTableAdapter.GetCurrentPriorMerchants();
            for (int rowIndex = 0; rowIndex < priorMerchantDataTable.Rows.Count; rowIndex++)
            {
                allPriorMerchants.Add(priorMerchantDataTable[rowIndex].MechantId, Convert.ToInt32(priorMerchantDataTable[rowIndex].PriorityScore));
            }
            var badMerchantTableAdapter = new BadMerchantsTableAdapter()
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var badMerchantDataTable = badMerchantTableAdapter.GetAllBadMerchantIds();
            for (int rowIndex = 0; rowIndex < badMerchantDataTable.Rows.Count; rowIndex++)
            {
                if(!allPriorMerchants.ContainsKey(badMerchantDataTable[rowIndex].MerchantId))
                allPriorMerchants.Add(badMerchantDataTable[rowIndex].MerchantId, -1);
            }
            return allPriorMerchants;
        }

        public static int GetNameLength(string name)
        {
            var realLenght = (double) (name.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).Length)/3;
            return (int)Math.Round(realLenght);
        }

        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember(
                    "CommandCollection",
                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (SqlCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
    }
}
