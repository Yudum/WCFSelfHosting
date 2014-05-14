using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ProductService));
            host.Open();
            Console.WriteLine("Servisin Durumu : " + host.State);
            Console.WriteLine("Servisi durdurmak için Enter'a basınız");
            Console.ReadLine();
            host.Close();
            Console.WriteLine("Servisin Durumu sacmalama lan : " + host.State);
            Console.ReadLine();
        }
    }
}
