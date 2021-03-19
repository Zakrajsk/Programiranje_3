using System;

namespace Pek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi predpisano tezo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi stevilo hlebcev v pekarni: ");
            int steviloHlebcev = int.Parse(Console.ReadLine());
            int stevecNapacnih = Preberi_in_prestej_napacne(tezaPredpis, steviloHlebcev);
            //računamo ali bo pek pil vodo
            if (Ali_goljufa(steviloHlebcev, stevecNapacnih)) Console.WriteLine("Peka v vodo takoj!!!!");
            else Console.WriteLine("Pek ima dobro mero");
        }

        /// <summary>
        /// Vrne true, ce je pek goljufal drugace false
        /// </summary>
        /// <param name="steviloHlebcev">Stevilo vseh hlebcev</param>
        /// <param name="stevecNapacnih">Koliko od teh je napacne teze</param>
        /// <returns>boolean</returns>
        private static bool Ali_goljufa(int steviloHlebcev, int stevecNapacnih)
        {
            return stevecNapacnih > steviloHlebcev * 0.15;
        }

        /// <summary>
        /// Prebere teze vseh hlebcev in zraven presteje koliko jih odstopa od napovedane teze
        /// </summary>
        /// <param name="tezaPredpis">Napovedana teza</param>
        /// <param name="steviloHlebcev">Koliko je vseh hlebcev</param>
        /// <returns>interger</returns>
        private static int Preberi_in_prestej_napacne(double tezaPredpis, int steviloHlebcev)
        {
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;
            for (int i = 1; i < steviloHlebcev; i++)
            {
                Console.Write("Vnesi tezo: " + i + ". hlebca ");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza)) stevecNapacnih++;
            }

            return stevecNapacnih;
        }
    }
}
