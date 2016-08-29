using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.BASE.LANGUAGE
{
   public  class AutoFixMarkText
    {
        public Dictionary<string, string> dicFix = new Dictionary<string, string>();
        public Dictionary<char, string> dicVovel = new Dictionary<char, string>();
        
       private  static AutoFixMarkText instance;
       public AutoFixMarkText Instance()
       {
           return instance == null ? (instance = new AutoFixMarkText()) : instance;
       }

        public AutoFixMarkText ()
        {
            string[] arFix = File.ReadAllLines(ConfigurationSettings.AppSettings["FixGrammar.txt"].ToString());
            foreach(string str in arFix )
            {
                string[] arConfig = str.Split(':');
                dicFix.Add(arConfig[0], arConfig[1]);
            }
            LoadDicVowel();
        }

        private void LoadDicVowel()
        {
            dicVovel.Add('a', "a");
            dicVovel.Add('á', "a'");
            dicVovel.Add('ả', "a?'");
            dicVovel.Add('à', "a-");
            dicVovel.Add('ạ', "a.");
            dicVovel.Add('ã', "a~");

            dicVovel.Add('ă', "ă");
            dicVovel.Add('ắ', "ă'");
            dicVovel.Add('ẳ', "ă?");
            dicVovel.Add('ằ', "ă-");
            dicVovel.Add('ặ', "ă.");
            dicVovel.Add('ẵ', "ă~");

            dicVovel.Add('â', "â");
            dicVovel.Add('ấ', "â'");
            dicVovel.Add('ẩ', "â?");
            dicVovel.Add('ầ', "â-");
            dicVovel.Add('ậ', "â.");
            dicVovel.Add('ẫ', "â~");

            dicVovel.Add('i', "i");
            dicVovel.Add('í', "i'");
            dicVovel.Add('ỉ', "i?");
            dicVovel.Add('ì', "i-");
            dicVovel.Add('ị', "i.");
            dicVovel.Add('ĩ', "i~");

            dicVovel.Add('y', "y");
            dicVovel.Add('ý', "y'");
            dicVovel.Add('ỷ', "y?");
            dicVovel.Add('ỳ', "y-");
            dicVovel.Add('ỵ', "y.");

            dicVovel.Add('u', "u");
            dicVovel.Add('ú', "u'");
            dicVovel.Add('ủ', "u?");
            dicVovel.Add('ù', "u-");
            dicVovel.Add('ụ', "u.");
            dicVovel.Add('ũ', "u~");

            dicVovel.Add('ư', "ư'");
            dicVovel.Add('ứ', "ư'");
            dicVovel.Add('ử', "ư?");
            dicVovel.Add('ừ', "ư-");
            dicVovel.Add('ự', "ư.");
            dicVovel.Add('ữ', "ư~");

            dicVovel.Add('ô', "ô'");
            dicVovel.Add('ố', "ô'");
            dicVovel.Add('ổ', "ô?");
            dicVovel.Add('ồ', "ô-");
            dicVovel.Add('ộ', "ô.");
            dicVovel.Add('ỗ', "ô~");

            dicVovel.Add('o', "o");
            dicVovel.Add('ó', "o'");
            dicVovel.Add('ỏ', "o?");
            dicVovel.Add('ò', "o-");
            dicVovel.Add('ọ', "o.");
            dicVovel.Add('õ', "o~");

            dicVovel.Add('ơ', "ơ'");
            dicVovel.Add('ớ', "ơ'");
            dicVovel.Add('ở', "ơ?");
            dicVovel.Add('ờ', "ơ-");
            dicVovel.Add('ợ', "ơ.");
            dicVovel.Add('ỡ', "ơ~");

            dicVovel.Add('e', "e");
            dicVovel.Add('é', "e'");
            dicVovel.Add('ẻ', "e?");
            dicVovel.Add('è', "e-");
            dicVovel.Add('ẹ', "e.");
            dicVovel.Add('ẽ', "e~");

            dicVovel.Add('ê', "ê");
            dicVovel.Add('ế', "ê'");
            dicVovel.Add('ể', "ê?");
            dicVovel.Add('ề', "ê-");
            dicVovel.Add('ệ', "ê.");
            dicVovel.Add('ễ', "ê~");
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
                else if (iBeginVowel > 0 && !IsVowel(arChar[i]))
                {
                    iEndVowel = i - 1;
                }
                else if (iBeginVowel > 0 && (i == arChar.Length - 1))
                {
                    iEndVowel = i;
                }
                if (iBeginVowel > 0 && iEndVowel > 0)
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

        public bool IsVowel (char charCheck)
        {
            if (dicVovel.ContainsKey(charCheck)) return true;
            else return false;
        }
    }
}
