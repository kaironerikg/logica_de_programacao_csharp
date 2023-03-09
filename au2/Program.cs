using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace au2
{
    internal class Program
    {
        public static int Programo { get; private set; }
        = 14;
        static void Main(string[] args)
        {
            int numeral;
            string nome;
            nome = "erik";
            numeral = Programo;
            int valor = Programo += 55;
            Console.WriteLine("bom dia");
            Console.WriteLine(nome);
            Console.WriteLine(Programo);
            Console.ReadLine();
            Console.Write("flws");
            Console.Write("flws");


        }
    }
}
