using System;

namespace Switch_stavek
{
    class Program
    {

        public static void Prva()
        {
            double stevilo1 = double.Parse(Console.ReadLine());
            double stevilo2 = double.Parse(Console.ReadLine());
            string operacija = Console.ReadLine();
            double rezultat = 0;

            switch (operacija)
            {
                case "+":
                    rezultat = stevilo1 + stevilo2;
                    break;

                case "-":
                    rezultat = stevilo1 - stevilo2;
                    break;

                case "*":
                    rezultat = stevilo1 * stevilo2;
                    break;

                case "/":
                    rezultat = stevilo1 / stevilo2;
                    break;

                default:
                    Console.WriteLine("Operator ni bil primeren");
                    break;
            }

            Console.WriteLine(rezultat);
        }

        public static void Druga_a()
        {
            int ocena = int.Parse(Console.ReadLine());

            switch (ocena)
            {
                case 10:
                case 9:
                    Console.WriteLine(10);
                    break;
                case 8:
                    Console.WriteLine(9);
                    break;
                case 7:
                    Console.WriteLine(8);
                    break;
                case 6:
                    Console.WriteLine(7);
                    break;
                case 5:
                    Console.WriteLine(6);
                    break;
                default:
                    Console.WriteLine("neg");
                    break;
            }
        }

        public static void Druga_b()
        {
            int ocena = int.Parse(Console.ReadLine());

            switch (ocena)
            {
                case int x when x < 100 && x > 90:
                    Console.WriteLine(10);
                    break;
                case int x when x < 89 && x > 80:
                    Console.WriteLine(9);
                    break;
                case int x when x < 79 && x > 70:
                    Console.WriteLine(8);
                    break;
                case int x when x < 69 && x > 60:
                    Console.WriteLine(7);
                    break;
                case int x when x < 59 && x > 50:
                    Console.WriteLine(6);
                    break;
                default:
                    Console.WriteLine("neg");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Prva();
            Druga_a();
            Druga_b();
        }

    }
}
