using System;

namespace Type_Safety_Marko
{
    class TypeSafety
    {
        public static int[] Sestej(int[] tab1, int[] tab2)
        {
            int[] vsota = new int[tab1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                vsota[i] = tab1[i] + tab2[i];
            }

            return vsota;
        }

        public static float[] Sestej(float[] tab1, float[] tab2)
        {
            float[] vsota = new float[tab1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                vsota[i] = tab1[i] + tab2[i];
            }

            return vsota;
        }

        public static double[] Sestej(double[] tab1, double[] tab2)
        {
            double[] vsota = new double[tab1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                vsota[i] = tab1[i] + tab2[i];
            }

            return vsota;
        }

        public static string[] Sestej<T>(T[] tab1, T[] tab2)
        {
            string[] vsota = new string[tab1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                vsota[i] = tab1[i].ToString() + tab2[i].ToString();
            }
            return vsota;
        }
        static void Main(string[] args)
        {
        }
    }
}
