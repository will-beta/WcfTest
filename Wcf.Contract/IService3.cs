using System.ServiceModel;

namespace Wcf
{
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        string DoWork(string str);
    }
}
