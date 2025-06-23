using System;

namespace TesteCodiumAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            int resultadoSoma = calc.Somar(5); // Erro: Está faltando o segundo argumento

            double resultadoDivisao = calc.Dividir(10, 0); // Isso vai gerar uma exceção em tempo de execução

            Console.WriteLine("Resultado da soma: " + resultadoSoma);
            Console.WriteLine("Resultado da divisão: " + resultadoDivisao);

            // Código com má prática: sem tratamento de exceção
        }
    }
}
