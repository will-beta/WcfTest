using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Wcf
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service4”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service4.svc 或 Service4.svc.cs，然后开始调试。
    public class Service4 : IService4
    {
        public string DoWork(string str)
        {
            Thread.Sleep(6000);
            return string.Format("{0} : {1}*", str, this);
        }
    }
}
