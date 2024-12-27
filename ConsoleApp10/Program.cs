using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Electonic electonic = new Electonic();
            phone Phone = new phone();
            electonic.turnoff();
            Console.WriteLine(electonic.getbrand);
            Console.WriteLine(electonic.getBatery);
            Console.WriteLine(electonic.getIson);
            Console.WriteLine();
            Console.WriteLine(Phone.getbrand);
            Console.WriteLine(Phone.getBatery);
            Console.WriteLine(Phone.getIson);
            Phone.turnoff();
            Phone.add(20);
        }
    }
}