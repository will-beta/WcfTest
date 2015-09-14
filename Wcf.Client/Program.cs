using System;
using System.ServiceModel;

namespace Wcf.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var factory = new ChannelFactory<IService2>("tcpService2"))
            {
                var del = factory.CreateChannel();
                var ret = del.DoWork("beta");
                Console.WriteLine("返回结果：{0}", ret);
            }
            Console.ReadKey();
        }
    }
}
