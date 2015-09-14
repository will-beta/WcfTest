using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DateTime.Now;
            try
            {
                a=a.AddSeconds(1);
                throw new Exception("what");
            }
            catch
            {
            }
            Console.WriteLine(a);
            Console.ReadLine();
            {
                var host = new WebServiceHost(typeof(Service));
                //const string uri = "https://localhost:443/Service1.svc/";
                const string uri = "http://localhost:444/Service1.svc";
                var binding = new WebHttpBinding
                    {
                        CrossDomainScriptAccessEnabled = true,
                        AllowCookies = true,
                        Security =
                            {
                                Mode = WebHttpSecurityMode.None
                                //Mode = WebHttpSecurityMode.Transport
                            }
                    };
                host.AddServiceEndpoint(typeof(IContract), binding, uri);
                host.Open();
            }
            {
                var host = new WebServiceHost(typeof(Service2));
                //const string uri = "https://localhost:443/Service1.svc/";
                const string uri = "http://localhost:444/Service2.svc";
                var binding = new WebHttpBinding
                    {
                        CrossDomainScriptAccessEnabled = true,
                        AllowCookies = true,
                        Security =
                            {
                                Mode = WebHttpSecurityMode.None
                                //Mode = WebHttpSecurityMode.Transport
                            }
                    };
                host.AddServiceEndpoint(typeof(IContract2), binding, uri);
                host.Open();
            }
            Console.WriteLine("REST Service with HTTPS is running ");
            Print(a);
            //Process.Start(uri);
            Console.ReadKey(true);
        }

        static void Print(object msg)
        {
            Console.WriteLine(msg+DateTime.Now.ToString());
        }
    }
}
