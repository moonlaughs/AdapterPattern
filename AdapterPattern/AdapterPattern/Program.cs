using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern!");

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());
        }
    }
}
