using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos= new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($@"Informe o aluno {i}:");
                alunos.Add(Console.ReadLine()); 
            }

            var alunoa = alunos.OrderByDescending(b=>b).FirstOrDefault(a => a.Equals("Alberto"));

            /*
            foreach (var aluno in alunos.OrderBy(a=>a))
            {
                Console.WriteLine($"Aluno {aluno}");
            }*/

            var listaAluno = new List<Tuple<string,int>>();

            listaAluno.Add(new Tuple<string, int>("a",1));

            listaAluno.FirstOrDefault().

            var aluno = new Tuple<string, int>("bob", 18);

        }
    }
}
