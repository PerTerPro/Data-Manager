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

        public void UpdateDocData(DocInfo docInfo)
        {
            string query = @"Update Documents Set

DateEnable = @DateEnable, 
DateNoEnable = @DateNoEnable, 
DatePost = @DatePost, 
DatePublish = @DatePublish, 
DateUsed = @DateUsed, 
DocNumber = @DocNumber, 
DocRef  = @DocRef, 
Enable = @Enable, 
PartNoEnable = @PartNoEnable, 
ReasonNoEnable = @ReasonNoEnable, 
Source = @Source, 
TypeDoc = @TypeDoc, 
DocFrom = @DocFrom,
Scope = @Scope,
LastUpdate = Getdate()

Where Id = @Id";
            this.sqlDb.RunQuery(query, CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("Id", docInfo.Id, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("DateEnable", docInfo.DateEnable, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DateNoEnable", docInfo.DateNoEnable, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DatePost", docInfo.DatePost, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DatePublish", docInfo.DatePublish, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DateUsed", docInfo.DateUsed, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DocNumber", docInfo.DocNumber, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DocRef", docInfo.DocRef, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Enable", docInfo.Enable, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("PartNoEnable", docInfo.PartNoEnable, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("ReasonNoEnable", docInfo.ReasonNoEnable, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Source", docInfo.Source, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("TypeDoc", docInfo.TypeDoc, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("DocFrom", docInfo.DocFrom, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Scope", docInfo.Scope, SqlDbType.NVarChar),

            });
        }


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
                                : variable.Item1.GetAttributeValue("name", ""),
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

        internal DataTable GetUrls()
        {
            return this.sqlDb.GetTblData("select Id, Url From Documents");
        }
    }
}
