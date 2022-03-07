using System;
using System.IO;


namespace NajSeIzvede.ignoriraj
{































































    [Serializable]
    class Analitik
    {
        private int count = 0;

        public void DobiPodatke()
        {
            count++;


































            throw new FileNotFoundException("L"); 














































        }
        public void Premisli()
        {



            count++;











































        }
        public void Analiziraj()
        {







































            count++;



















































            throw new ArithmeticException("O");




















































        }
        public void PredebatirajAnalizo()
        {

            count--;




            throw new ArgumentException("O:");




        }
        public void ShraniAanalizoVBazo()
        {

            count++;



            throw new IndexOutOfRangeException("L");


        }
        public void Zakljuci()
        {

            count++;

        }
        public void Preveri()
        {
            string tocke = $"Dobil si {count}/5 točk.";
            Console.WriteLine(tocke);
        }
    }
}
