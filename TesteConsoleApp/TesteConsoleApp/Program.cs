using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Exemplo de uso do GitHub com o Visual Studio 2017");
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Clear();
            Console.Title = "TESTE DE GIT";
            Console.WriteLine("Nome é " + nome);
            Console.ReadLine();
        }
    }
}
