﻿using System;

namespace Lista1
{
    public static class Atividade5
    {
        public static void Main()
        {
            double aplicacaoMensal = 0;
            double taxa = 0;
            int numMeses = 0;


            Console.WriteLine("Digite o valor da aplicaçao mensal: ");
            Console.Write("> ");
            aplicacaoMensal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa: ");
            Console.Write("> ");
            taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de meses: ");
            Console.Write("> ");
            numMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu rendimento é: " + (aplicacaoMensal * (Math.Pow((1 + taxa),numMeses) - 1)/taxa));
        }
    }
}