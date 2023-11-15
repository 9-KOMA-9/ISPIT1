using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provjera_znanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite rečenicu: ");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1.Replace(" ","_"));
            Console.ReadKey();
        }
    }
}
