using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService4”。
    [ServiceContract]
    public interface IService4
    {
        [OperationContract]
        string DoWork(string str);
    }
}
