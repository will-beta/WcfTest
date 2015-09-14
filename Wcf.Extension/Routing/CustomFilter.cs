using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Wcf.Extension.Routing
{
    public class CustomFilter:MessageFilter
    {
        public CustomFilter(string endpointName)// : base(endpointName)
        {
        }

        public override bool Match(MessageBuffer buffer)
        {
            return true;
        }

        public override bool Match(System.ServiceModel.Channels.Message message)
        {
            return false;
            //return base.Match(message);
        }
    }
}
