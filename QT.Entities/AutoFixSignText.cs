using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.BASE.LANGUAGE
{
   public  class AutoFixSignText
    {
       string strVowel =
            "a á à ả ạ ă ắ ằ ẳ ặ â ấ ầ ẩ ậ "
           + "e é è ẻ ẹ ê ề ế ể ệ "
           + "u ú ù ủ ụ ư ừ ứ ử ự "
           + "y ỳ ý ỷ ỵ i ì í ỉ ị "
           + "o ò ó ỏ ọ ô ồ ố ổ ộ ơ ờ ớ ở ợ"
           + "A Á À Ả Ạ Ă Ắ Ằ Ẳ Ặ Â Ấ Ầ Ậ"
           + "E É È Ẻ Ẹ Ê Ế Ề Ể Ệ"
           + "U Ú Ù Ủ Ụ Ư Ứ Ừ Ử Ự"
           + "O Ó Ò Ỏ Ọ Ô Ố Ồ Ổ Ộ Ơ Ờ Ớ Ở Ợ"
           + "Y Ý Ỳ Ỷ Ỵ I Í Ì Ỉ Ị";
        private Dictionary<string, string> dicFix = new Dictionary<string, string>();
        private bool[] arChar = new bool[200000];
        QT.Entities.DBTableAdapters.ConfigFixSignTextTableAdapter _adapter;
           
       private  static AutoFixSignText instance;
       public static AutoFixSignText Instance()
       {
           return instance == null ? (instance = new AutoFixSignText()) : instance;
       }

        public AutoFixSignText ()
        {
            QT.Entities.DB.ConfigFixSignTextDataTable tblConfigFix = new QT.Entities.DB.ConfigFixSignTextDataTable();
            _adapter = new QT.Entities.DBTableAdapters.ConfigFixSignTextTableAdapter();
            _adapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            _adapter.Fill(tblConfigFix);
            foreach(QT.Entities.DB.ConfigFixSignTextRow row in tblConfigFix.Rows )
            {
                dicFix.Add(row.InputText, row.OutputText);
            }

            foreach(char c in this.strVowel)
            {
                if (c!=' ')
                {
                    arChar[c] = true;
                }
                else
                {
                    arChar[c] = false;
                }
            }

            //LoadDicVowel();
        }


        public string FixLongText(string inputText)
        {
            char[] arChar = inputText.ToArray<char>();
            int iBeginVowel = -1;
            int iEndVowel = -1;
            for (int i = 0; i < arChar.Length; i++)
            {
                if (IsVowel(arChar[i]) && iBeginVowel < 0 && iEndVowel < 0)
                {
                    iBeginVowel = i;
                    iEndVowel = -1;
                }
                else if (iBeginVowel >= 0 && !IsVowel(arChar[i]))
                {
                    iEndVowel = i - 1;
                }
                else if (iBeginVowel >= 0 && (i == arChar.Length - 1))
                {
                    iEndVowel = i;
                }
                if (iBeginVowel >= 0 && iEndVowel >= 0)
                {
                    string arFix = FixVowel(SubText(arChar, iBeginVowel, iEndVowel));
                    if (arFix.Length >= 0)
                    {
                        for (int ii = iBeginVowel; ii <= iEndVowel; ii++)
                        {
                            arChar[ii] = arFix[ii - iBeginVowel];
                        }
                    }

                    iEndVowel = -1;
                    iBeginVowel = -1;
                }
            }
            string str = new string(arChar);
            return str;
        }

        public string SubText (char[] arChar, int iBegin,int iEnd)
        {
            string strReturn = "";
            for (int i = iBegin; i <= iEnd; i++)
            {
                strReturn += arChar[i].ToString();
            }
            return strReturn;
        }

        private string FixVowel (string inputText)
        {
            if (!dicFix.ContainsKey(inputText)) return inputText;
            else return dicFix[inputText];
        }

       /// <summary>
       /// Kiểm tra nguyên âm
       /// </summary>
       /// <param name="charCheck"></param>
       /// <returns></returns>
        private bool IsVowel (char charCheck)
        {
            return arChar[charCheck];
            //if (dicVovel.ContainsKey(charCheck)) return true;
            //else return false;
        }
    }
}
