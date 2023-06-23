using System;

namespace Lista1
{
    public static class Atividade1
    {
        public static void Main()
        {
            double baseT = 0;
            double altura = 0;

            Console.WriteLine("Informe um valor para a base: ");
            baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor para a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("O perímetro do retângulo é: " + (baseT * 2 + altura * 2));
            Console.WriteLine("A diagonal do retângulo é: " + Math.Sqrt(Math.Pow(baseT, 2) + Math.Pow(altura, 2)));
            Console.WriteLine("A área do retângulo é: " + baseT * altura);
        }
    }
}
