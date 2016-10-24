using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using QT.Entities.Data;

namespace WSS.DocMan
{
    internal class DocManAdapter
    {
        private SqlDb sqlDb = new SqlDb(ConfigDocMan.ConnectionSql);

        public void InsertData(Documet document)
        {
            const string strData = @"

Delete From Documents where Id = @Id
Delete From Menu Where DocumentId = @Id
Delete From DocChapter where DocumentId = @Id

Insert 
Into Documents (Id, TextDoc, HtmlDoc, Url) Values (@Id, @TextDoc, @HtmlDoc, @Url);
 
Select Top 1 Id From Documents Order By Id DESC
";
            DataTable tbl = this.sqlDb.GetTblData(strData, CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("@TextDoc", document.TextDoc, SqlDbType.NText),
                SqlDb.CreateParamteterSQL("@HtmlDoc", document.HtmlDoc, SqlDbType.NText),
                SqlDb.CreateParamteterSQL("@Id", document.Id, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@Url", document.Url, SqlDbType.NVarChar),
            });
         
            var lstMenu = document.LstStructure;
            if (document.LstStructure != null && document.LstStructure.Count > 0)
            {
                foreach (var variable in lstMenu)
                {
                    const string str = "Insert Into Menu (ParentId, Text, Ref, DocumentId) Values (@ParentId, @Text, @Ref, @DocumentId) " +
                                       "Select Top 1 Id From Menu Order By Id Desc";

                    DataTable tbl1 = this.sqlDb.GetTblData(str, CommandType.Text, new SqlParameter[]
                    {

                        SqlDb.CreateParamteterSQL("Text",
                            (variable.Item1 == null) ? "" : variable.Item1.InnerText.Trim(),
                            SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("ParentId", 0, SqlDbType.Int),
                        SqlDb.CreateParamteterSQL("DocumentId", document.Id, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("Ref",
                            (variable.Item1.Name == "")
                                ? ""
                                : variable.Item1.SelectSingleNode(".//a[@name]").GetAttributeValue("name", ""),
                            SqlDbType.NVarChar),
                      
                    });


                    long chuongId = Convert.ToInt64(tbl1.Rows[0]["Id"]);
                    string strChapter = "Insert Into DocChapter (IdMenu,  Text, Html, DocumentId) Values (@IdMenu, @Text, @Html, @DocumentId)";
                    
                    this.sqlDb.RunQuery(strChapter, CommandType.Text, new SqlParameter[]
                    {
                        SqlDb.CreateParamteterSQL("@IdMenu", chuongId, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@DocumentId", document.Id, SqlDbType.BigInt),
                        SqlDb.CreateParamteterSQL("@Text",
                            string.Join("", variable.Item2.Select(a => a.InnerText).ToList()), SqlDbType.NText),
                        SqlDb.CreateParamteterSQL("@Html",
                            string.Join("", variable.Item2.Select(a => a.OuterHtml).ToList()), SqlDbType.NText)
                    });

                    foreach (var VARIABLE in variable.Item3)
                    {
                        string strQ = "Insert Into Menu (ParentId, Ref, DocumentId) Values (@ParentId, @Ref, @DocumentId)";
                        this.sqlDb.RunQuery(strQ, CommandType.Text, new[]
                        {
                            SqlDb.CreateParamteterSQL("ParentId", chuongId, SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("Ref", VARIABLE, SqlDbType.NVarChar),
                            SqlDb.CreateParamteterSQL("DocumentId", document.Id, SqlDbType.BigInt),
                        });
                    }
                }
            }
        }
    }
}
