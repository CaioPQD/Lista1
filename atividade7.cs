using System;

namespace Lista1
{
    public static class Atividade7
    {
        public static void Main()
        {
            int diasSemAcidentes = 0;
            int numMeses = 0;
            int numAnos = 0;

            Console.WriteLine("Informe a quantidade de dias sem acidentes: ");
            Console.Write("> ");
            diasSemAcidentes = int.Parse(Console.ReadLine());

            if (diasSemAcidentes >= 365)
            {
                numAnos = diasSemAcidentes / 365;
                diasSemAcidentes = diasSemAcidentes % 365;
            }
            if (diasSemAcidentes >= 30)
            {
                numMeses = diasSemAcidentes / 30;
                diasSemAcidentes = diasSemAcidentes % 30;
            }

            Console.WriteLine(numAnos + " Anos, " + numMeses + " Meses e " + diasSemAcidentes + " Dias");
        }
    }
}