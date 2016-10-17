using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using log4net;using QT.Entities.Data;

namespace ImboForm
{
    public class TestReadImbo
    {private Queue<string> lst = new Queue<string>();private ILog log = log4net.LogManager.GetLogger(typeof (TestReadImbo));
        private int countThread = 2;
        private DateTime startRun;
        private SqlDb sqlDb = new SqlDb(SettingSystem.GetSetting().ConnectionSql);
        private int iCount = 0;
        private int total;

        public TestReadImbo()
        {
            
        }

        public void InitData()
        {
            string query =
           @"select  top 20000 'http://192.168.100.34/users/xtpu/images/' + ImageId + '.jpg' + '?t[]=thumbnail:width=200,height=200,fit=inset order by id' as Link
from product where ImageId is not null";
            DataTable tbl = this.sqlDb.GetTblData(query, CommandType.Text, null);

            foreach (DataRow VARIABLE in tbl.Rows)
            {
                string l =
                    @"http://img.websosanh.net/ThumbImages/Store/images/nhi/nhiet-ke-dien-tu-do-tran-medisana-tm-65e_2001.jpg";
                l =
                    @"http://192.168.100.34/users/xtpu/images/cq9Tk057w0u9.jpg?t[]=thumbnail:width=200,height=200,fit=inset";
                l = @"http://192.168.100.34/aha.php";
                lst.Enqueue(l);
                //l = VARIABLE["Link"].ToString();lst.Enqueue(l);}
                this.total = this.lst.Count;
            }
        }

        public void TestMulThread1()
        {
            for (int i = 0; i < 100; i++)
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
                            @"http://192.168.100.34/users/xtpu/images/cq9Tk057w0u9.jpg?t[]=thumbnail:width=200,height=200,fit=inset";WebRequest req = WebRequest.Create(l);
                        WebResponse response = req.GetResponse();
                        Stream stream = response.GetResponseStream();
                        StreamReader sr = new StreamReader(stream);
                        string rel = sr.ReadToEnd();
                        if (iLoop%1000 == 0)
                            log.Info(string.Format("Thread {0} => {1}/{3}. => {2}", j, iLoop, "",
                                (DateTime.Now - dtStart).TotalMilliseconds));}
                    log.Info(string.Format("Thread {0} end", j));
                });
            }
        }

        public void Run()
        {
            this.startRun = DateTime.Now;
            for (int i = 0; i < countThread; i++)
            {
                Task.Factory.StartNew(() =>{
                    while (true)
                    {
                        try
                        {
                            if (iCount%1000 == 0) log.Info(iCount);
                            if (lst.Count > 0)
                            {
                                iCount++;
                                var VARIABLE = lst.Dequeue();
                                WebRequest req = WebRequest.Create(VARIABLE);
                                WebResponse response = req.GetResponse();
                                Stream stream = response.GetResponseStream();
                                stream.Close();}
                            else
                            {
                                log.InfoFormat("Run at {1} {0}", (DateTime.Now - startRun).TotalMilliseconds, total);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                });
            }
        }
    }
}
