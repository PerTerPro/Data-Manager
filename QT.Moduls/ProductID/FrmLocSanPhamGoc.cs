using ProtoBuf;
using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.ProductID
{
    public partial class FrmLocSanPhamGoc : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmLocSanPhamGoc));

        public FrmLocSanPhamGoc()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(new Action(() =>
                {
                    SqlDb sqlDb = new SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
                    List<ProductNameHashEntry> lstTempSave = new List<ProductNameHashEntry>();
                    List<string> lstPrefix = new List<string>();
                    ProductNameHashEntry productNameHashLast = null;

                    for (int i = 0; i < 10000; i++)
                    {
                        lstPrefix.Add(i.ToString("000"));
                        lstPrefix.Add("-" + i.ToString("000"));
                    }
                    var database = RedisManager.GetRedisServer("redisProductNameHashMapping").GetDatabase(1);
                    
                    foreach(string item in lstPrefix)
                    {
                        //if (Math.Abs(Convert.ToInt32(item)) <= 174) continue;
                        this.Invoke(new Action(() =>
                        {
                            this.richTextBox1.AppendText(string.Format("\r\n Run at {0}", item));
                        }));

                        string str = string.Format("PRODUCT_NAMECRC_REV:{0}*", item.ToString());
                        var x = database.HashKeys(str);
                        int a = x.Length;

                        int countItemOf = 0;

                        while (true)
                        {
                            try
                            {
                                IEnumerable<RedisKey> redisKeys = GetEntryByRegex(str);
                                foreach (var key in redisKeys)
                                {
                                    countItemOf++;
                                    string keyProcess = key.ToString();
                                    HashEntry[] hashEntrys = GetHashALl(database, keyProcess);
                                    int length = hashEntrys.Length;
                                    int countFail = 0;

                                    foreach (var hashEntry1 in hashEntrys)
                                    {
                                        ProductNameHashEntry productNameHashEntry = Serializer.Deserialize<ProductNameHashEntry>(new MemoryStream(hashEntry1.Value));
                                        if (productNameHashEntry.RootProductID == 0)
                                        {
                                            countFail++;
                                            productNameHashLast = productNameHashEntry;
                                            productNameHashLast.NameRedis = hashEntry1.Name.ToString();
                                        }
                                    }

                                    if ((countFail > length / 2) && length > 2)
                                    {
                                        sqlDb.RunQuery("If Not Exists (Select ID From ProductNotMapRoot Where ID = @ID) BEgin Insert Into ProductNotMapRoot (ID, IDNotRoot, IDCompany, DateAdd, Length, CountFail) Values (@ID, @IDNotRoot, @IDCompany, GetDate(),  @Length, @CountFail) End",
                                              CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                                            SqlDb.CreateParamteterSQL("ID", Convert.ToInt64(keyProcess.Replace("PRODUCT_NAMECRC_REV:","")),SqlDbType.BigInt),
                                            SqlDb.CreateParamteterSQL("IDNotRoot",Convert.ToInt64(productNameHashLast.NameRedis),SqlDbType.BigInt),
                                            SqlDb.CreateParamteterSQL("IDCompany",productNameHashLast.CompanyID,SqlDbType.BigInt),
                                            SqlDb.CreateParamteterSQL("Length",length,SqlDbType.Int),
                                            SqlDb.CreateParamteterSQL("CountFail",countFail,SqlDbType.Int)
                                       });
                                    }

                                }
                                log.Info("running at item:" + item + "Number item:" + countItemOf);
                                break;
                            }
                            catch (Exception ex01)
                            {
                                log.Error(ex01.Message);
                            }
                        }
                    }
                }));
            
        }

        private HashEntry[] GetHashALl(IDatabase database, string keyProcess)
        {
            while (true)
            {
                try
                {
                    return database.HashGetAll(keyProcess);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }

        private  IEnumerable<RedisKey>  GetEntryByRegex(string str)
        {
            while (true)
            {
                try
                {
                   return  RedisManager.GetRedisServer("redisProductNameHashMapping")
                                     .GetServer("172.22.1.175", 11318)
                                     .Keys(1, str, 1000000, CommandFlags.None);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }
    }
}
