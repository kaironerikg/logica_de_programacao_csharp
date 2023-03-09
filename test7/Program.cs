using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double id1, id2, id3, idt1, idt2;

            id1 = Convert.ToInt32(Console.ReadLine());
            id2 = Convert.ToInt32(Console.ReadLine());
            id3 = Convert.ToInt32(Console.ReadLine());
            id1 = id1 - id2;
            idt2 = id1 * id3;
            Console.WriteLine("faltão " + id1 + " parcelas ");
            Console.WriteLine("sera nessecario desenbolsar " + idt2 + " reais ");
            Console.ReadLine(); 
        }
    }
}
