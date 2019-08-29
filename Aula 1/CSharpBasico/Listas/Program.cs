using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaLista = new List<int>();

            minhaLista.Add(1);
            minhaLista.Add(2);
            minhaLista.Add(3);



            Console.WriteLine("Maior valor:"+minhaLista.Max());
            Console.WriteLine("Menor valor:" +minhaLista.Min());
            Console.WriteLine("Quantidade itens:"+minhaLista.Count);
            Console.WriteLine("O numero 5 esta na minha lista: "+  minhaLista.Exists(a=>a== 5).ToString());

            Console.ReadKey();


        }
    }
}
