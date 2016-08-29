using DevExpress.XtraCharts;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.KeywordSuggest
{
    public partial class FrmChartMaxVolume : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
        
        public FrmChartMaxVolume()
        {
            InitializeComponent();
        }

        private void FrmChartMaxVolume_Load(object sender, EventArgs e)
        {
            DataTable tbl = this.sqlDb.GetTblData(@"  select top 200 * 
  from Keyword_Volume_Source a
  left join Keyword_VolumeHistory b on a.ID = b.Id ", CommandType.Text, null);

            DataTable tblExtraction = new DataTable();
            tblExtraction.Columns.Add("keyword", typeof(string));
            tblExtraction.Columns.Add("volume", typeof(int));
            tblExtraction.Columns.Add("month",typeof(int));

            foreach (DataRow rowInfo in tbl.Rows)
            {
                int month_01 = rowInfo["month_01"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_01"]);
                int month_02 = rowInfo["month_02"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_02"]);
                int month_03 = rowInfo["month_03"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_03"]);
                int month_04 = rowInfo["month_04"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_04"]);
                int month_05 = rowInfo["month_05"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_05"]);
                int month_06 = rowInfo["month_06"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_06"]);
                int month_07 = rowInfo["month_07"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_07"]);
                int month_08 = rowInfo["month_08"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_08"]);
                int month_09 = rowInfo["month_09"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_09"]);
                int month_10 = rowInfo["month_10"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_10"]);
                int month_11 = rowInfo["month_11"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_11"]);
                int month_12 = rowInfo["month_12"] == DBNull.Value ? 0 : QT.Entities.Common.Obj2Int(rowInfo["month_12"]);

                int[] arVolumen = new int[] { month_01, month_02, month_03, month_04, month_05, month_06, month_07, month_08, month_09, month_10, month_11, month_12 };
                int maxValud = arVolumen.Max<int>();
                for (int i = 0; i < arVolumen.Length; i++)
                {
                    if (arVolumen[i]==maxValud)
                    {
                        DataRow rowNew = tblExtraction.NewRow();
                        rowNew["keyword"] = rowInfo["keyword"].ToString();
                        rowNew["volume"] = maxValud;
                        rowNew["month"] = i+1;
                        tblExtraction.Rows.Add(rowNew);
                    }
                }

            }


            this.chartControl1.Series.Clear();

            Series seri = new Series("Side-by-Side Bar Series 1", ViewType.Point);
            this.chartControl1.Series.Add(seri);
            foreach (DataRow row in tblExtraction.Rows)
            {
                seri.Points.Add(new SeriesPoint(row["keyword"].ToString(), new double[] { Convert.ToInt32(row["month"])}));
            }

            this.chartControl1.DataSource = tblExtraction;
        }
    }
}
