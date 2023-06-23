using System;

namespace Lista1
{
    public static class Atividade6
    {
        public static void Main()
        {
            double A;
            double B;

            Console.WriteLine("informe um valor para ser armazenado na variavel A: ");
            Console.Write("> ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("informe um valor para ser armazenado na variavel B: ");
            Console.Write("> ");
            B = double.Parse(Console.ReadLine());

            double aux = A;
            A = B;
            B = aux;

            Console.WriteLine("Os valores das variaveis trocaram, A: " + A + " e B: " + B);
        }
    }
}