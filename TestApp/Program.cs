using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello " + LibA.LibAClass.Name);
            Console.WriteLine("Hello " + LibB.LibBClass.Name);
            // PrivateLib is unavailable here: 
            // Console.WriteLine("Hello " + PrivateLib.PrivateLibClasss.Name);
        }
    }
}
