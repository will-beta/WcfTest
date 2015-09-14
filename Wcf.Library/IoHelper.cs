using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Wcf.Library
{
    public static class IoHelper
    {
        public static void WriteText(this string str)
        {
            var msg = string.Format("{0} {1} (create on {2})", DateTime.Now, str, new FileInfo(Assembly.GetExecutingAssembly().FullName).LastWriteTime);
            DoWriteIntoEvent(msg);
        }

        private static void DoWriteIntoEvent(string str)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    var log = new EventLog("Application") { Source = "Application" };
                    log.WriteEntry(str, EventLogEntryType.Information);
                }
                catch
                {
                }
            });
        }
    }
}
