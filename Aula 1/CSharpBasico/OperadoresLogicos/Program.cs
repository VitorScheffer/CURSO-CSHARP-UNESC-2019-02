using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {


            if (ehTrue() || ehTrue())
            {
                Console.WriteLine("Resultado true");
            }
            else
            {
                Console.WriteLine("resultado false");
            }

            Console.ReadKey();
        }

        public static bool ehTrue()
        {
            Console.WriteLine("verificou true");
            return true;
        }

        public static bool ehFalse()
        {
            Console.WriteLine("verificou false");
            return false;
        }
    }
}
