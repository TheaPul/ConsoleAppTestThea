using ConsoleAppTestThea.Classes;
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

            //Console.Write ("Geben Sie Ihren Namen ein: ");
            ////
            //string name = Console.ReadLine ();
            //if (name == "")
            //    Console.WriteLine ("Haben Sie keinen Namen?");
            //else
            //    Console.WriteLine ($"Ihr Name ist \'{name}\'");
            //Console.ReadLine ();
            Person peter = new Person ("Peter");
            peter.birthdate = "01.07.1944";
            Console.WriteLine ("Person Name = "+peter.Name);
            Console.WriteLine ("Person Geburtsdatum = " + peter.birthdate);
            Console.ReadLine ();
        }
    }
}
