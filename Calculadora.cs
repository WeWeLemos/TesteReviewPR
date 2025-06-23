namespace TesteCodiumAI
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisor não pode ser zero.");

            return a / b;
        }
    }
}
