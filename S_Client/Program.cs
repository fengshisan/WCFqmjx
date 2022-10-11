using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using S_Interface;

namespace S_Client
{
    internal class Program
    {
        /// <summary>
        /// 接口的配置里写验证，也就是那个<sn ……></sn>,然后使用的时候需要打开服务，才能够正常运行，试一下别的方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>("calculatorservice"))
            {
                ICalculator calculator=channelFactory.CreateChannel();
                 Console.WriteLine("结果是" + calculator.Add(5, 6));
                //using (OperationContextScope contextScope = new OperationContextScope(calculator as IClientChannel))
                //{
                //    string sn = "{DDA095DA-93CA-49EF-BE01-EF5B47179FD0}";
                //    string ns = "http://www.artech.com/";
                //    AddressHeader addressHeader = AddressHeader.CreateAddressHeader("sn", ns, sn);
                //    MessageHeader messageHeader = addressHeader.ToMessageHeader();
                //    OperationContext.Current.OutgoingMessageHeaders.Add(messageHeader);
                //    Console.WriteLine("结果是" + calculator.Add(5, 6));
                //}
            }
            Console.ReadKey();
        }
    }
}
