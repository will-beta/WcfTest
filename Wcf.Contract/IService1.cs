using System.ServiceModel;

namespace Wcf
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string DoWork(string str);
    }
}
