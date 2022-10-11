using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculatorServiceClient client = new CalculatorServiceClient();
            //for (; ; )
            //{
            //    Console.WriteLine("请输入数据1：");
            //    double x = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("请输入数据2：");
            //    double y = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(client.Sub(x, y));
            //    Console.WriteLine(client.Mul(x, y));
            //    Console.WriteLine(client.Add(x, y));
            //    Console.WriteLine(client.Div(x, y));
            //}
            // 当使用ChannelFactory<TChannel>进行获取终结点并和服务接口通信的时候，需要和服务接口的终结点配置一致，这里指Services的配置。
            //using (ChannelFactory<ICalculator> ChannelFactory = new ChannelFactory<ICalculator>
            //    (new WSHttpBinding(), "http://127.0.0.1:3721/calculator"))

            // 也可以直接在配置里配置终结点，更方便
            using (ChannelFactory<ICalculator> ChannelFactory = new ChannelFactory<ICalculator>("calculatorservice"))
            {
                ICalculator client = ChannelFactory.CreateChannel();
                Console.WriteLine("请输入数据1：");
                double x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("请输入数据2：");
                double y = Int32.Parse(Console.ReadLine());
                Console.WriteLine(client.Sub(x, y));
                Console.WriteLine(client.Mul(x, y));
                Console.WriteLine(client.Add(x, y));
                Console.WriteLine(client.Div(x, y));
                Console.ReadLine();
            }

        }
    }
}
