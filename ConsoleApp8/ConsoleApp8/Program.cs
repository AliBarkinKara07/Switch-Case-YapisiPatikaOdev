using System;
using System.Linq.Expressions;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış Veri Girdiniz");
                    break;
            }
        }
    }
}
