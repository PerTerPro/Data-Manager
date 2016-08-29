using QT.Entities;
using QT.Entities.Data;
using QT.Entities.RaoVat;
using QT.Moduls.CrawlSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmSyncDataMySqlAndSqlServer : Form
    {
        public FrmSyncDataMySqlAndSqlServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textProcess = comboBox1.Text.ToLower();
            if (textProcess != "")
            {
                Thread thread = new Thread(() => RunData(textProcess));
                thread.Start();
            }
            else
            {
                MessageBox.Show(textProcess);
            }
        }

        private void RunData(string textProcess)
        {
            this.Invoke(new Action(() =>
            {
                this.btnStart.Visible = false;
            }));

            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            MySqlAdapterRaoVat mySqlAdapterRaoVat = new MySqlAdapterRaoVat();
            RaoVatSQLAdapter sqlAdapterRaoVat = new RaoVatSQLAdapter(sqlDb);

            if (textProcess == "cities")
            {
                var dicCity = mySqlAdapterRaoVat.GetDicCity();
                for (int i = 0; i < dicCity.Count; i++)
                {
                    var itemCity = dicCity.ElementAt(i);
                    if (sqlAdapterRaoVat.CheckExistCity(itemCity.Key))
                    {
                        sqlAdapterRaoVat.UpdateCity(itemCity.Key, itemCity.Value);
                    }
                    else
                    {
                        sqlAdapterRaoVat.InsertCity(itemCity.Key, itemCity.Value);
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.progressBar1.Value = Convert.ToInt32(((double)i / (double)dicCity.Count) * 100);
                    }));
                }
            }
            else if (textProcess == "categories")
            {
                DataTable tblcategories = mySqlAdapterRaoVat.GetTableCategories();
                for (int i = 0; i < tblcategories.Rows.Count; i++)
                {
                    var itemCity = tblcategories.Rows[i];
                    if (sqlAdapterRaoVat.CheckExistCategories(Convert.ToInt32(itemCity["id"])))
                    {
                        sqlAdapterRaoVat.UpdateCategories(new QT.Entities.RaoVat.RaoVatCategory()
                        {
                            id = Convert.ToInt32(itemCity["id"]),
                            level = Convert.ToInt32(itemCity["level"]),
                            name = Common.Obj2String(itemCity["name"]),
                            parent_id = Common.Obj2Int(itemCity["parent_id"]),
                            slug = Common.Obj2String(itemCity["slug"]),
                            path  =Common.Obj2String(itemCity["path"])
                        });
                    }
                    else
                    {
                        sqlAdapterRaoVat.InsertCategory(new QT.Entities.RaoVat.RaoVatCategory()
                        {
                            id = Convert.ToInt32(itemCity["id"]),
                            level = Convert.ToInt32(itemCity["level"]),
                            name = Common.Obj2String(itemCity["name"]),
                            parent_id = Common.Obj2Int(itemCity["parent_id"]),
                            slug = Common.Obj2String(itemCity["slug"]),
                            path = Common.Obj2String(itemCity["path"])
                        });
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.progressBar1.Value = Convert.ToInt32(((double)i / (double)tblcategories.Rows.Count) * 100);
                    }));
                }
            }

            this.Invoke(new Action(() =>
            {
                this.btnStart.Visible = true;
            }));

        }
    }
}
