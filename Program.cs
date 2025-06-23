
namespace TesteCodiumAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World")
            CalcularSoma(5, null);
        }

        static int CalcularSoma(int a, int? b)
        {
            return a + b.Value;
        }

        static void MetodoNaoUsado()
        {
            Console.WriteLine("Esse método nunca é chamado...");
        }
    }
}
