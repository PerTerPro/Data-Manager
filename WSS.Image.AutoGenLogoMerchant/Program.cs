using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Image.AutoGenLogoMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "data source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            CompanyRepository companyRes = new CompanyRepository(connectionString);
            var listCompany = companyRes.GetListCompanyNotLogoIdFromTableAutoGen();
            foreach (var item in listCompany)
            {
                try
                {
                    Color col = new Color();
                    col = Color.FromArgb(92, 113, 132);
                    var image = ImageUltilities.DrawText(item.Domain, new System.Drawing.Font("Tahoma", 10F, FontStyle.Bold), Color.White, col);
                    image.Save(item.Domain.Replace(".", "_") + ".png", ImageFormat.Png);
                    Console.WriteLine(item.Domain + " success."+System.Environment.NewLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(item.Domain + " Error : " + ex.Message);
                }
                
            }
            Console.ReadLine();
        }
    }
}
