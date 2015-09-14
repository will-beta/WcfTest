using System.ServiceModel;

namespace Wcf
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string DoWork(string str);
    }
}
