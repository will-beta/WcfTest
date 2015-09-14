using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestTest
{
    public class Service2:IContract2
    {
        public string GetMessage()
        {
            return "2 Hello From HTTPS";
        }
    }
}
