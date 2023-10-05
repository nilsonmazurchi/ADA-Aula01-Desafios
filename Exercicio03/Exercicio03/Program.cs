using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main()
        {
            // Solicite ao usuário que insira o valor total da conta
            Console.Write("Digite o valor total da conta: R$ ");
            double valorConta = Convert.ToDouble(Console.ReadLine());

            // Solicite ao usuário que insira a porcentagem de gorjeta desejada
            Console.Write("Digite a porcentagem de gorjeta desejada: ");
            double porcGorjeta = Convert.ToDouble(Console.ReadLine());

            // Calcule o valor da gorjeta
            double valorGorjeta = (valorConta * porcGorjeta) / 100;

            // Calcule o total a ser pago (conta + gorjeta)
            double totalConta = valorConta + valorGorjeta;

            // Exiba o valor da gorjeta e o total a ser pago na tela
            Console.WriteLine($"O valor da gorjeta é: R$ {valorGorjeta:F2}");
            Console.WriteLine($"o total a ser pago (conta + gorjeta)é: R$ {totalConta:F2}");

            // Aguarde que o usuário pressione uma tecla antes de sair
            Console.ReadKey();
        }
    }
}
