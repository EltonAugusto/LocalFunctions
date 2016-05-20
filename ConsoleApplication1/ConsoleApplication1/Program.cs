using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication1
{
    class Program
    {

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Empresa { get; set; }

        }

        static void Main(string[] args)
        {
            var listaMensagens = new Dictionary<int, string>
                { { 1, $"{nameof(Pessoa.Nome)}:" },
                  { 2, $"{nameof(Pessoa.Email)}:" },
                  { 3, $"{nameof(Pessoa.Empresa)}:" }
                };

            string exibirMensagem(int posicaoAtual = 0)
            {
                WriteLine(listaMensagens[posicaoAtual + 1].ToString());
                return ReadLine();
            }


            var pessoa = new Pessoa();

            pessoa.Nome = exibirMensagem();
            pessoa.Email = exibirMensagem(1);
            pessoa.Empresa = exibirMensagem(2);

            ReadKey();

        }

    }
}
