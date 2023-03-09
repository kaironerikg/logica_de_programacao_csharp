using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double id1, id2, id3,idt;

            id1 = Convert.ToInt32(Console.ReadLine());
            id2 = Convert.ToInt32(Console.ReadLine());
            id3 = Convert.ToInt32(Console.ReadLine());
            idt = id1 * id2 * id3 /1000;
            Console.WriteLine(idt);
            Console.ReadLine();
        }
    }
}
