using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestThea
{
    class Program
    {
        static void Main (string[] args)
        {
            //int input = Console.Read ();
            //Console.WriteLine (input);
            //Console.ReadLine ();

            Console.Write ("Geben Sie Ihren Namen ein: ");
            string name = Console.ReadLine ();
            if (name == "")
                Console.WriteLine ("Haben Sie keinen Namen?");
            else
                Console.WriteLine ($"Ihr Name ist \'{name}\'");
            Console.ReadLine ();
        }
    }
}
