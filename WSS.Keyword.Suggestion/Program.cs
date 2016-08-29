using OpenQA.Selenium;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Keyword.Suggestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.Run();
            Console.WriteLine();
        }
    }
}
