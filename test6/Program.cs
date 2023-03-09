using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1, anos , mes, semanas;

            id1 = Convert.ToInt32(Console.ReadLine());
            semanas = id1 / 7;
            mes = id1 / 30;
            anos = id1 / 360;
            Console.WriteLine(semanas + " semanas " + mes + " messes " + anos + " anos");
            Console.ReadLine();

        }
    }
}
