using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.MapProperties.Product.Has.ProductId.Workers;

namespace WSS.Crl.MapProperties.Product.Has.ProductId
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkerMapProperties wk = new WorkerMapProperties();
            wk.StartConsume();


        }

    }
}
