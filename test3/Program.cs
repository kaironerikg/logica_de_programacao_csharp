using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double id1, id2, id3, id4, id5, idt;
            
            id1 = Convert.ToInt32(Console.ReadLine());
            id2 = Convert.ToInt32(Console.ReadLine());
            id3 = Convert.ToInt32(Console.ReadLine());
            id4 = Convert.ToInt32(Console.ReadLine());
            id5 = Convert.ToInt32(Console.ReadLine());
            idt = id1 + id2 + id3 + id4 + id5;
            Console.WriteLine(idt);
            Console.ReadLine();
        }
    }
}
