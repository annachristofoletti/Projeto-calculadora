using System;

namespace Calculadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double numero1, numero2;


            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());

            double subtracao = numero1 - numero2;
            double soma = numero1 + numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("A subtração dos numeros é:" + subtracao);
            Console.WriteLine("A soma dos números é: " + soma);
            Console.WriteLine("A multiplicação dos números é: " + multiplicacao);
            Console.WriteLine("A divisão dos numeros é:" + divisao);
        }
    }
}