using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main()
        {
            // Solicite ao usuário que insira um valor em reais
            Console.Write("Digite o valor em reais: R$ ");
            double valorReais = Convert.ToDouble(Console.ReadLine());

            // Defina as taxas de conversão para dólar e euro
            double taxaDolar = 5.50;
            double taxaEuro = 6.50;

            // Calcule o valor equivalente em dólares e euros
            double valorDolar = valorReais / taxaDolar;
            double valorEuro = valorReais / taxaEuro;

            // Exiba os valores convertidos na tela
            Console.WriteLine($"Valor em dólares: ${valorDolar:F2}");
            Console.WriteLine($"Valor em euros: €{valorEuro:F2}");

            
        }
    }
  


}
