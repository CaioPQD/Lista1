﻿using System;


namespace Lista1

{
    public static class atividade2
    {
        public static void main()
        {
            double cateto1 = 0;
            double cateto2 = 0;
        //apresentando erro de referencia nula, mas teoricamente a função de converter do teclado para a variavel esta certa 
            Console.WriteLine("Informe um valor para o cateto 1: ");
            cateto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro valor para cateto 2: ");
            cateto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A hipotenusa sera: " + Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2)));
        }
    }
}




