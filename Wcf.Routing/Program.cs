using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Wcf.Routing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WCF Routing Service";

            using (var host = new ServiceHost(typeof(System.ServiceModel.Routing.RoutingService)))
            {
                ////判断是否以及打开连接，如果尚未打开，就打开侦听端口
                if (host.State != CommunicationState.Opening)
                    host.Open();

                //显示运行状态
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Routing Service is runing! and state is {0}", host.State);

                //print endpoint information
                foreach (var se in host.Description.Endpoints)
                {
                    Console.WriteLine("Host is listening at {0}", se.Address.Uri);
                }

                //等待输入即停止服务
                Console.WriteLine("Press any key to exit.");
                Console.Read();
            }
        }
    }
}
