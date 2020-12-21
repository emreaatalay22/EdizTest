using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// 
        ///  int tamSayi = 1;
        ///    string hello = "Merhaba";
        ///   string fullName = "Ediz Beşevli";
        ///   Console.WriteLine(hello + " " + fullName);
        ///   double ondalikliSayi = 0.5;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Sayısal işlemlere başlamak için Topla,Çarpma ... Örnek 1 + 2 = 3 gibi bilgiler yazınız.");

            var cmd2 = Console.ReadLine();

            if (cmd2 == "Topla")
            {
                Console.WriteLine("Lütfen rakamları giriniz.");
                int birinciRakam = int.Parse(Console.ReadLine());
                int ikinciRakam = int.Parse(Console.ReadLine());

                int toplam = Topla(birinciRakam, ikinciRakam);

                Console.WriteLine("Sayıların toplam:" + toplam.ToString());
            }
            else if (cmd2 == "Bolme")
            {
                Console.WriteLine("Lütfen rakamları giriniz.");
                int birinciRakam = int.Parse(Console.ReadLine());
                int ikinciRakam = int.Parse(Console.ReadLine());
                int bolmeSonucu = Bolme(birinciRakam, ikinciRakam);

                Console.WriteLine("Bolme işleminin sonucu:" + bolmeSonucu.ToString());

            }
            else if (cmd2 == "Bolme Ondalik")
            {
                Console.WriteLine("Lütfen rakamları giriniz.");
                double birinciRakam = int.Parse(Console.ReadLine());
                double ikinciRakam = int.Parse(Console.ReadLine());
                double bolmeSonucu = BolmeOndalik(birinciRakam, ikinciRakam);

                Console.WriteLine("Bolme işleminin sonucu:" + bolmeSonucu.ToString());

            }
            else if (cmd2 == "Carpma")
            {
                Console.WriteLine("Lütfen rakamları giriniz.");
                int birinciRakam = int.Parse(Console.ReadLine());
                int ikinciRakam = int.Parse(Console.ReadLine());
                int carpmaSonucu = Carpma(birinciRakam, ikinciRakam);
                Console.WriteLine("Carpma işleminin sonucu:" + carpmaSonucu.ToString());
            }
            else if (cmd2 == "Cikarma")
            {
                Console.WriteLine("Lütfen rakamları giriniz.");
                int birinciRakam = int.Parse(Console.ReadLine());
                int ikinciRakam = int.Parse(Console.ReadLine());
                int cikarmaSonucu = Cikarma(birinciRakam, ikinciRakam);
                Console.WriteLine("Cikarma işleminin sonucu:" + cikarmaSonucu.ToString());
            }
            Console.ReadLine();

        }
        private static int Topla(int birinciRakam, int ikinciRakam)
        {
            return birinciRakam + ikinciRakam;
        }
        private static int Bolme(int birinciRakam, int ikinciRakam)
        {
            return birinciRakam / ikinciRakam;
        }
        private static double BolmeOndalik(double birinciRakam, double ikinciRakam)
        {
            return birinciRakam / ikinciRakam;
        }
        private static int Carpma(int birinciRakam, int ikinciRakam)
        {
            return birinciRakam * ikinciRakam;
        }

        private static int Cikarma(int birinciRakam, int ikinciRakam)
        {
            return birinciRakam - ikinciRakam;
        }
    }
}

