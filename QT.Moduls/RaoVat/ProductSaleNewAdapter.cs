using QT.Entities;
using QT.Entities.Data;
using QT.Entities.RaoVat;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.RaoVat
{
    public class ProductSaleNewAdapter
    {
        private SqlDb sqlDb = null;
        public ProductSaleNewAdapter(SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
        }

        public List<string> GetListBlackRegexKeyWord()
        {
            DataTable tbl = this.sqlDb.GetTblData("select RegexKeyWord From [RegexFindKeyWord] Where IsValid = 0", CommandType.Text,
                new SqlParameter[] { });
            List<string> lst = new List<string>();
            foreach(DataRow row in tbl.Rows)
            {
                lst.Add(Convert.ToString(row["RegexKeyword"]));
            }
            return lst;
        }

        public List<string> GetListRegexKeyword()
        {
            return null;
        }

        public DataTable GetTblRunner()
        {
            return this.sqlDb.GetTblData("select a.id, a.name, a.state, b.base_link from runner_crawler a left join website b on a.website_id = b.id ");
        }

        public Entities.RaoVat.RunnerCrawler GetRunnerCrawler(int idSelected)
        {
            DataTable tbl = this.sqlDb.GetTblData("select * from runner_crawler where id = @id", CommandType.Text, new System.Data.SqlClient.SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("id",idSelected,SqlDbType.Int)
                });
            if (tbl != null && tbl.Rows.Count > 0)
            {
                RunnerCrawler runnerCrawler = new RunnerCrawler();
                ParseRunnerCrawler(tbl.Rows[0], runnerCrawler);
                return runnerCrawler;
            }
            else
            {
                return null;
            }
        }

        private void ParseRunnerCrawler(DataRow dataRow, RunnerCrawler runnerCrawler)
        {
            runnerCrawler.id = Common.Obj2Int(dataRow["id"]);
            runnerCrawler.name = Common.Obj2String(dataRow["name"]);
            runnerCrawler.website_id = Common.Obj2Int(dataRow["website_id"]);
            runnerCrawler.is_find_new = Common.Obj2Bool(dataRow["is_find_new"]);
            runnerCrawler.is_reload_item = Common.Obj2Bool(dataRow["is_reload_item"]);
            runnerCrawler.last_end = Common.ObjectToDataTime(dataRow["last_end"]);
            runnerCrawler.last_push = Common.ObjectToDataTime(dataRow["last_push"]);
            runnerCrawler.max_deep = Common.Obj2Int(dataRow["max_deep"]);
            runnerCrawler.max_item = Common.Obj2Int(dataRow["max_item"]);
            runnerCrawler.max_time_run_crawler = Common.Obj2Int(dataRow["max_time_run_crawler"]);
            runnerCrawler.number_thread = Common.Obj2Int(dataRow["number_thread"]);
            runnerCrawler.root_link = QT.Entities.Common.GetListXPathFromString(Common.Obj2String(dataRow["root_link"]));
            runnerCrawler.second_sleep_recrawler = Common.Obj2Int(dataRow["second_sleep_recrawler"]);
        }



        public bool SaveRunner(RunnerCrawler runnerCrawler)
        {
            SqlParameter[] parameter = new SqlParameter[]{
                SqlDb.CreateParamteterSQL("id",runnerCrawler.id,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("name",runnerCrawler.name,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("description",runnerCrawler.description,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("is_find_new",runnerCrawler.is_find_new,SqlDbType.Bit),
                SqlDb.CreateParamteterSQL("is_reload_item",runnerCrawler.is_reload_item,SqlDbType.Bit),
                SqlDb.CreateParamteterSQL("max_deep",runnerCrawler.max_deep,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("max_item",runnerCrawler.max_item,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("max_time_run_crawler",runnerCrawler.max_time_run_crawler,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("number_thread",runnerCrawler.number_thread,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("root_link",Common.ConvertToString( runnerCrawler.root_link),SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("second_sleep_recrawler",runnerCrawler.second_sleep_recrawler, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("website_id",runnerCrawler.website_id,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("state",runnerCrawler.state,SqlDbType.Int)
            };

            if (runnerCrawler.id == 0)
            {
                this.sqlDb.RunQuery(@"INSERT INTO [dbo].[runner_crawler]
           ([website_id]
           ,[root_link]
           ,[number_thread]
           ,[second_sleep_recrawler]
           ,[is_find_new]
           ,[is_reload_item]
           ,[max_deep]
           ,[max_item]
           ,[description]
           ,[name]
           ,[max_time_run_crawler]
           ,[state]) values 
           (@website_id
           ,@root_link
           ,@number_thread
           ,@second_sleep_recrawler
           ,@is_find_new
           ,@is_reload_item
           ,@max_deep
           ,@max_item
           ,@description
           ,@name
           ,@max_time_run_crawler
           ,@state)", CommandType.Text, parameter);

            }
            else
            {
                this.sqlDb.RunQuery(@"
UPDATE [dbo].[runner_crawler]
   SET [website_id] = @website_id
      ,[root_link] = @root_link
      ,[number_thread] = @number_thread
      ,[second_sleep_recrawler] = @second_sleep_recrawler
      ,[is_find_new] = @is_find_new
      ,[is_reload_item] = @is_reload_item
      ,[max_deep] = @max_deep
      ,[max_item] = @max_item
      ,[description] = @description
      ,[name] = @name
      ,[max_time_run_crawler] = @max_time_run_crawler
      ,[state] = @state 
       WHERE id = @id", CommandType.Text, parameter);
            }
            return true;
        }

        internal DataTable GetTblKeyWordNeedUpdate()
        {
            return this.sqlDb.GetTblData("select top 10000 * from VatGiaKeyword where isnull(status,0)=0",CommandType.Text
                ,new SqlParameter[]{});
        }

        internal void UpdateStateOfKeyWord(long crc, int p)
        {
            this.sqlDb.RunQuery("update VatGiaKeyword set status = @status where id = @id", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("id",crc,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("status",p,SqlDbType.Int)
                });
        }

        public DataTable GetListWebSite()
        {
            return this.sqlDb.GetTblData("select id, website, domain from website", CommandType.Text, new SqlParameter[] { });
        }

        public WebsiteRaoVat GetWebSiteRaoVat(int website_id)
        {
            DataTable tbl = this.sqlDb.GetTblData("Select * From WebSite Where Id = @Id", CommandType.Text,
                new SqlParameter[]{
                    new SqlParameter("id",website_id)
                });
            DataRow row = tbl.Rows[0];
            WebsiteRaoVat websiteRaoVat = new WebsiteRaoVat();
            websiteRaoVat.base_link = row["base_link"].ToString();
            websiteRaoVat.domain = Common.CompactUrl(row["domain"].ToString());
            websiteRaoVat.id = Convert.ToInt32(row["id"]);
            websiteRaoVat.config_id = Convert.ToInt32(row["config_id"]);
            return websiteRaoVat;
        }

        public void AddRunnerCrawler()
        {
            this.sqlDb.RunQuery("Insert Into runner_crawler (name) values ('new item')", CommandType.Text, new SqlParameter[] { });
        }
    }
}
