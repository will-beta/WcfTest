using System;
using System.ServiceModel.Activation;
using Wcf.Library;

namespace Wcf.Extension.Hosting
{
    public class CustomServiceHostFactory : ServiceHostFactory
    {
        protected override System.ServiceModel.ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ("Creating：" + serviceType).WriteText();

            var host = base.CreateServiceHost(serviceType, baseAddresses);
            host.Opening += (a, b) => ("Opening：" + serviceType).WriteText();
            host.Opened += (a, b) => ("Opened：" + serviceType).WriteText();
            host.Closing += (a, b) => ("Closing：" + serviceType).WriteText();
            host.Closed += (a, b) => ("Closed：" + serviceType).WriteText();
            host.Faulted += (a, b) => ("Faulted：" + serviceType).WriteText();
            return host;
        }
    }
}
