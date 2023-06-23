using System;

namespace Lista1
{
    public static class Atividade4
    {
        public static void Main()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;

            Console.WriteLine("Digite um valor para X1: ");
            Console.Write("> ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y1: ");
            Console.Write("> ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para X2: ");
            Console.Write("> ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y2: ");
            Console.Write("> ");
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A distancia entre os 2 pontos é: " + Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)));
        }
    }
}
