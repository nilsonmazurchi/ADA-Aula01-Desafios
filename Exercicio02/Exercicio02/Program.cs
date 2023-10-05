using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main()
        {
            // Solicite ao usuário que insira o ano atual
            Console.Write("Digite o ano atual: ");
            int anoAtual = Convert.ToInt32(Console.ReadLine());

            // Solicite ao usuário que insira o ano de nascimento
            Console.Write("Digite o ano de nascimento: ");
            int anoNasc = Convert.ToInt32(Console.ReadLine());

            // Calcule a idade
            int idade = anoAtual - anoNasc;

            // Exiba a idade no console
            Console.WriteLine($"Sua idade é: {idade} anos.");

            // Aguarde que o usuário pressione uma tecla antes de sair
            Console.ReadKey();
        }
    }
}
