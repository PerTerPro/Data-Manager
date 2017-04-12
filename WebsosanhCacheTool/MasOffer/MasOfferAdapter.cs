using System;
using System.Collections.Generic;
using System.Data;
using log4net;

namespace WebsosanhCacheTool.MasOffer
{
    public class MasOfferAdapter
    {
        private static  string _connectionProduct = "";
        private static SqlDb _sqlDb = null;

        private   Dictionary<long, MasOfferCompany> _dicData = null;
        private  DateTime _lastSysnListMasoffer = DateTime.Now;
        private static MasOfferAdapter _ins;
        private static ILog _log = log4net.LogManager.GetLogger(typeof (MasOfferAdapter));

        public MasOfferAdapter()
        {
        }

        public static  MasOfferAdapter Instance()
        {
            return _ins ?? (_ins = new MasOfferAdapter());

        }

        public static void SetConnection(string connectionString)
        {
            if (connectionString != _connectionProduct)
            {
                _connectionProduct = connectionString;
                _sqlDb = new SqlDb(MasOfferAdapter._connectionProduct);
                _log.Info("MasOffer connected!");
            }

        }

        private static object _lock = new object();
        private  void SyncListMasOffer()
        {
            try
            {
                lock (_lock)
                {
                    if (_dicData == null || (DateTime.Now - _lastSysnListMasoffer).TotalMinutes > 120)
                    {
                        if (_dicData == null) _dicData = new Dictionary<long, MasOfferCompany>();
                        _dicData.Clear();
                        DataTable tblData = _sqlDb.GetTblData("prc_Company_GetMasOfferAll", CommandType.StoredProcedure,
                            null);
                        foreach (DataRow variable in tblData.Rows)
                        {
                            long companyId = Convert.ToInt64(variable["Id"]);
                            _dicData.Add(companyId, new MasOfferCompany()
                            {
                                Id = companyId,
                                MasOfferCode = Convert.ToString(variable["MasOfferCode"]),
                                SubDomain = Convert.ToString(variable["SubDomain"]),
                            });
                        }
                        _lastSysnListMasoffer = DateTime.Now;
                        _log.Info(string.Format("Last sync data Company Masoffer {0}", _lastSysnListMasoffer));
                    }
                }
            }
            catch (Exception ex01)
            {
                _log.Error(ex01);
            }
        }

        public  bool CheckIsMasOffer(long companyId)
        {
            SyncListMasOffer();
            return _dicData.ContainsKey(companyId);

        }



        public  string GetFullUrl(long companyId, string  url)
        {
            SyncListMasOffer();
            if (this.CheckIsMasOffer(companyId))
            {
                var ms = this._dicData[companyId];
                var urlMas = string.Format(@"https://{0}/v0/{1}/websosanh/?go={2}",
                    (string.IsNullOrEmpty(ms.SubDomain)) ? "go.masoffer.net" : ms.SubDomain, ms.MasOfferCode,
                    System.Web.HttpUtility.UrlEncode(url));
                //_log.Info("UrlMasOffer: " + urlMas);
                return urlMas;
            }
            return url;
        }
    }
}
