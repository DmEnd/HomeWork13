using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building bulding = new Building("ул.Садовая", 20, 10.5, 9);
            Console.WriteLine(bulding.Print());

            MultiBuilding multiBuilding = new MultiBuilding("ул.Арбузная", 40, 20.6, 15,5);
            Console.WriteLine(multiBuilding.Print());

            Console.ReadKey();
        }
    }
}
