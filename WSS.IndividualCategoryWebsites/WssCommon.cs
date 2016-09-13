using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.IndividualCategoryWebsites.DBIndiTableAdapters;

namespace WSS.IndividualCategoryWebsites
{
    public class WssCommon
    {
        public enum ListWebCommand
        {
            IndividualWebsitesProduct = 1,
            IndividualWebsitesRootProductAnalyzed = 2,
            ViewTagInWebsites =3
        }

        public static string GetNameCategoryById(int id)
        {
            var categoriesTableAdapter = new CategoriesTableAdapter();
            categoriesTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            var categoriesDataTable = new DBIndi.CategoriesDataTable();
            try
            {
                categoriesTableAdapter.FillById(categoriesDataTable,id);
                if (categoriesDataTable.Rows.Count > 0)
                    return categoriesDataTable.Rows[0]["Name"].ToString();
                else return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
