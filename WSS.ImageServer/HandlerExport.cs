using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSS.ImageServer
{
    public class HandlerExport
    {
        public void RunData()
        {
            Dictionary<string,List<string>> dicData = new Dictionary<string, List<string>>();
            string[] arFiles = File.ReadAllLines("Input.txt");
            foreach(string str in arFiles)
            {
                string[] arFile = str.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);
                if (arFile.Length > 1)
                {
                    string domain = arFile[0];
                    if (!dicData.ContainsKey(domain)) dicData.Add(domain, new List<string>());
                    
                    string[] phones = arFile[1].Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string phone in phones)
                    {
                        string phoneParse = this.ParsePhone(phone);
                        if (!string.IsNullOrEmpty(phoneParse) && IsMobilePhone(phoneParse))
                        {
                            if (!dicData[domain].Contains(phoneParse))
                            {
                                dicData[domain].Add(phoneParse);
                            }
                        }
                    }
                    if (dicData[domain].Count == 0) dicData.Remove(domain);
                }
            }
            var lst = dicData.Select((t, i) => dicData.ElementAt(i).Key + " \t " + string.Join("-", dicData.ElementAt(i).Value)).ToList();
            string end = string.Join("\n", lst);

        }

        private bool IsMobilePhone(string phoneParse)
        {
            if (phoneParse.StartsWith("09")) return true;
            else if (phoneParse.StartsWith("01")) return true;
            else return false;
        }

        private string ParsePhone(string phone)
        {
            string phoneParse = Regex.Replace(phone, "[^0-9]", "");
            if (phoneParse.Length > 9)
            {
                return phoneParse;
            }
            return "";
        }
    }
}
