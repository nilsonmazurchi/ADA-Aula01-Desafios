using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main()
        {
            // Solicite ao usuário que insira dois números
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Realize as operações
            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = 0;

            // Verifique se o segundo número não é zero para evitar a divisão por zero
            if (numero2 != 0)
            {
                divisao = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Exiba os resultados no console
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");

            // Aguarde que o usuário pressione uma tecla antes de sair
            Console.ReadKey();
        }
    }
}
