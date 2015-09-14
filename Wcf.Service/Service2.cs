using System;
using System.ServiceModel;
using System.Threading;
using Wcf.Library;

namespace Wcf
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service2 : IService2
    {
        private static readonly DateTime CreateDateTime = DateTime.Now;

        public Service2()
        {
            string.Format("{0} Instance Creating", this).WriteText();
        }

        public string DoWork(string str)
        {
            "start".WriteText();
            //Thread.Sleep(1000);
            "end".WriteText();
            return string.Format("{0} : {1} on {2} (create on {3})", str, this, DateTime.Now, CreateDateTime);
        }
    }
}
