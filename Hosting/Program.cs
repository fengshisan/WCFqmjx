using System;
using Service.Interface;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Calculator)))
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:3721/calculator");
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:3721/calculator/metadata");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate
                {
                    Console.WriteLine("Calculator服务已经启动，按任意键终止服务");
                };

                host.Open();
                Console.ReadLine();
            }
        }
    }
}
