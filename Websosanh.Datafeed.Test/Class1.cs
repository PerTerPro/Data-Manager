using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QT.Entities;
using Websosanh.Datafeed.Imp;
using Websosanh.Datafeed.Model;

namespace Websosanh.Datafeed.Test
{
    [TestFixture()]
    public class DataFeedTest
    {
        [Test()]
        public void ReadCsvFile()
        {
            Websosanh.Datafeed.Imp.CsvReaderProduct csv = new CsvReaderProduct(new DatafeedConfigRepository());
            csv.ReadDataFeedProductsFromCsvFile(@"C:\Users\xuantrang\Documents\feed.csv", 3502170206813664485, "lazada.vn",
                (object sender, Product p) =>
                {
                    Console.WriteLine(p.Name);
                });
        }

        [Test()]
        public void ShouldGetProductIdListTest ()
        {
            Websosanh.Datafeed.Imp.CsvReaderProduct csv = new CsvReaderProduct(new DatafeedConfigRepository());
            var productIds = csv.GetProductIds(@"C:\Users\xuantrang\Documents\feed.csv", 3502170206813664485, "lazada.vn");
            Assert.Greater(productIds.Count, 1);
        }

        [Test()]
        public void ShouldGenerateIdProduct()
        {
            string detailUrl = @"http://ho.lazada.vn/SHDCvl?url=http%3A%2F%2Fwww.lazada.vn%2Flac-tay-bac-nu-dep-ltn0079-trang-suc-tnj-4704973.html%3Foffer_id%3D%7Boffer_id%7D%26affiliate_id%3D%7Baffiliate_id%7D%26offer_name%3D%7Boffer_name%7D_%7Boffer_file_id%7D%26affiliate_name%3D%7Baffiliate_name%7D%26transaction_id%3D%7Btransaction_id%7D%26aff_source%3D%7Bsource%7D&aff_sub=&aff_sub2=&aff_sub3=&aff_sub4=&aff_sub5=&source=";
            string regexConfig = @"http://www.lazada.vn/.+html";
            long id = UtilIdProduct.GenerateId(detailUrl, regexConfig);
            long expectId = 318946526279756;
            Assert.AreEqual(id, expectId);
        }

        [Test()]
        public void TestGetAllIdProductLazada()
        {
            ProductRepository productRepository = new ProductRepository();
            var productId = productRepository.GetProductIds(3502170206813664485);
            int nProduct = productId.Count;
        }
    }
}
