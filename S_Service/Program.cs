using System;
using System.ServiceModel;

namespace S_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                Console.WriteLine("服务已经启动");
                host.Open();
                Console.Read();
            }
        }
    }
}
