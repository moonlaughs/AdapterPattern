using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Adaptee
    {
        public string GetOtherRequest()
        {
            return "other request";
        }
    }
}
