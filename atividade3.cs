using System;

namespace Lista1
{
    public static class Atividade3
    {
        public static void Main()
        {
            double salario = 0;
            int kwGastos = 0;
            double valorKw = 0;
            double valorPagar = 0;

            Console.WriteLine("Digite o valor do salario minimo: ");
            Console.Write("> ");
            salario = double.Parse(s: Console.ReadLine());

            Console.WriteLine("Digite o valor gasto de kilawatts em 1 mes: ");
            Console.Write("> ");
            kwGastos = int.Parse(s: Console.ReadLine());

            valorKw = (salario / 7)/100;
            valorPagar = valorKw * kwGastos;

            Console.WriteLine("Cada Kilawatt vale: " + valorKw);
            Console.WriteLine("Valor dos kilawatts gatos desse mes: " + valorPagar);
            Console.WriteLine("Valor com desconto: " + (valorPagar - (valorPagar * 0.1)));
        }
    }
}
