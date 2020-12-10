using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Adapter : ITarget
    {
        Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return "This is" + _adaptee.GetOtherRequest();
        }
    }
}
