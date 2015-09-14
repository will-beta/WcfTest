using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestTest
{
    public class Service:IContract
    {
        public string GetMessage()
        {
            return "Hello From HTTPS";
        }
    }
}
