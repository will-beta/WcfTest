using System;

namespace Wcf
{
    public class Service1 : IService1
    {
        public string DoWork(string str)
        {
            return string.Format("{0} : {1}", str, this);
        }
    }
}
