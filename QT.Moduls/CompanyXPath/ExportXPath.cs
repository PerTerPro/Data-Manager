using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CompanyXPath
{
    public class ExportXPath
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExportXPath));
        SqlDb _sqlDb = null;
        public ExportXPath (SqlDb _sqlDb)
        {
            this._sqlDb = _sqlDb;
        }

        public List<StructCompanyXPath> ExportXPathData ()
        {
            QT.Entities.Server.ConnectionString = _sqlDb.connection.ConnectionString;
            List<StructCompanyXPath> lstStructCompany = new List<StructCompanyXPath>();
            DataTable tblCompany = _sqlDb.GetTblData("select  id from company where status = 1 and datafeedtype = 0");

            int i=0;
            foreach(DataRow rowInfo in tblCompany.Rows)
            {
                log.Info(string.Format("{0}/{1}", i++, tblCompany.Rows.Count));

                long CompanyID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                QT.Entities.Company company = new QT.Entities.Company(CompanyID);
                Configuration config = new Configuration(CompanyID);
                lstStructCompany.Add(new StructCompanyXPath()
                    {
                        CompanyID = CompanyID,
                        Website = company.Website,
                        structXpath = new StructXPath()
                        {
                            ProductNameXPath=config.ProductNameXPath,
                            ImageXPath=config.ImageXPath,
                            PriceXPath=config.PriceXPath,
                            StatusXPath=config.StatusXPath,
                            VATInfoXPath = config.VATInfoXPath,
                            PromotionInfoXPath = config.PromotionInfoXPath,
                            OriginPriceXPath = config.OriginPriceXPath,
                            CategoryXPath = config.CategoryXPath,
                            StartDealXPath = config.StartDealXPath,
                            EndDealXPath = config.EndDealXPath,
                        }
                    });
            }
            return lstStructCompany;
        }
    }
}
