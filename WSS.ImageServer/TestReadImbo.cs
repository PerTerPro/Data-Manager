using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;using QT.Entities.Data;

namespace ImboForm
{
    public class TestReadImbo
    {
        private Queue<string> lst = new Queue<string>();
        private ILog log = log4net.LogManager.GetLogger(typeof (TestReadImbo));
        private int countThread =10;
        private DateTime startRun = DateTime.Now;private SqlDb sqlDb = new SqlDb(SettingSystem.GetSetting().ConnectionSql);

        private int total;

        public TestReadImbo()
        {
        }

        public void InitData()
        {
            string query =
                @"select  top 20000 ImageId From Product WHere ImageId Is Not NUll order by Id";
            DataTable tbl = this.sqlDb.GetTblData(query, CommandType.Text, null);

            foreach (DataRow VARIABLE in tbl.Rows)
            {
                string l =string.Format(
                        "http://192.168.100.34/users/xtpu/images/{0}.jpg?t[]=thumbnail:width=200,height=200,fit=insert",
                        VARIABLE["ImageId"].ToString());

                //    @"http://img.websosanh.net/ThumbImages/Store/images/nhi/nhiet-ke-dien-tu-do-tran-medisana-tm-65e_2001.jpg";
                //l =
                //    @"http://192.168.100.34/users/xtpu/images/6OE-fWXdPAaY.jpg";
                ////l = @"http://192.168.100.34/aha.php";
                //lst.Enqueue(l);

                //l = VARIABLE["ImageId"].ToString();
                //l = string.Format("http://192.168.100.34/users/xtpu/images/{0}.jpg", l);

                //l = "http://192.168.100.34/users/xtpu/images/XOT87Q9cvx7W.jpg";
                //l = "http://review.websosanh.net/Images/Uploaded/Share/2016/10/17/lzdabbotthotdeal2.jpg";
                lst.Enqueue(l);}
            this.total = this.lst.Count;
        }


        public void InitDataWebSosanhCurrent()
        {
            string query =
                @"select top 200000 ImagePath,ImageUrls
from product
where company = 3502170206813664485
and ImagePath is not null
and valid = 1";

            SqlDb sqlDbP = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
            DataTable tbl = sqlDbP.GetTblData(query, CommandType.Text, null);

            foreach (DataRow VARIABLE in tbl.Rows)
            {
                string l = VARIABLE["ImagePath"].ToString();
                if (l.Contains(".jpg"))
                {
                    l = @"http://img.websosanh.net/ThumbImages/" + l.Replace(".jpg", "_200.jpg");
                    lst.Enqueue(l);
                }
            }
            this.total = this.lst.Count;
        }

        public void TestMulThread1()
        {
            for (int i = 0; i < 10; i++)
            {
                int j = i;
                Task.Factory.StartNew(() =>
                {

                    log.Info(string.Format("Thread {0} start", j));
                    DateTime dtStart = DateTime.Now;
                    for (int iLoop = 0; iLoop < 1000000; iLoop++)
                    {
                        var l = @"http://192.168.100.34/";
                        l =
                            @"http://192.168.100.34/users/xtpu/images/cq9Tk057w0u9.jpg?t[]=thumbnail:width=200,height=200,fit=inset";
                        WebRequest req = WebRequest.Create(l);
                        WebResponse response = req.GetResponse();
                        Stream stream = response.GetResponseStream();
                        StreamReader sr = new StreamReader(stream);
                        string rel = sr.ReadToEnd();
                        if (iLoop%1000 == 0)
                            log.Info(string.Format("Thread {0} => {1}/{3}. => {2} queue: {4}", j, iLoop, "",
                                (DateTime.Now - dtStart).TotalMilliseconds, lst.Count));
                    }
                    log.Info(string.Format("Thread {0} end", j));
                });
            }
        }

        private int iCount = 0;
        private object objIcountS = new object();
      

        public void TestPerformanceDownload()
        {
            InitDataWebSosanhCurrent();
        
            for (int i = 0; i < countThread; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        lock (objIcountS)
                        {
                            if (iCount%1000 == 0)
                            {
                                int x = (int) (DateTime.Now - startRun).TotalSeconds;
                                log.Info(string.Format("{0}/{1}    => {2} {3}", iCount, x, (double) iCount/(double) x,
                                    lst.Count));
                            }
                        }

                        if (lst.Count > 0)
                        {
                            iCount++;
                            var variable = lst.Dequeue();

                            //string newFile = string.Format(AppDomain.CurrentDomain.BaseDirectory +
                            //                               @"\IMG\{0}.jpg", Guid.NewGuid().ToString());
                            //using (WebClient client = new WebClient())
                            //{
                            //    client.DownloadFile(variable, newFile);//}

                            if (variable!=null)
                            {
                                try
                                {

                                    WebRequest req = WebRequest.Create(variable);
                                    req.Method = "GET";
                                    WebResponse response = req.GetResponse();
                                    var x = response.GetResponseStream();
                                    //log.Info(x);
                                    response.Close();
                                }
                                catch (Exception ex)
                                {
                                    //log.Error(variable + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            log.InfoFormat("TestPerformanceDownload at {1} {0}",
                                (DateTime.Now - startRun).TotalMilliseconds, total);
                            return;
                        }
                    }

                });
            }
        }
    }
}
