using System;
using System.Collections.Generic;
using System.Text;

namespace OdevNeseYonelimliProgramlama
{
    public static class HesapMak
    {
        public static void HesapMakinası(double sayi1, double sayi2, double sonuc)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("lütfen işlem seçin....");
            Console.WriteLine("1.    Toplam (+)");
            Console.WriteLine("2.    Çıkarma(-)");
            Console.WriteLine("3.    Çarpma (*)");
            Console.WriteLine("4.    Bölme  (/)");
            Console.WriteLine("******************************");
            Console.Write("Lütfen işlemin sembolünü yazınız: ");
            string islem = Console.ReadLine();

            double sonuc = 0;

            double sayi1 = Convert.ToDouble(Console.ReadLine());
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }

            switch (islem)
            {
                case "+":
                    Console.Write($"sonuc ={sayi1 + sayi2}");
                    break;
                case "-":
                    Console.Write($"sonuc ={sayi1 - sayi2}");
                    break;
                case "*":
                    Console.Write($"sonuc ={sayi1 * sayi2}");
                    break;
                case "/":
                    Console.Write($"sonuc ={sayi1 / sayi2}");
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("******************************");
            Console.Read();
        }

        
    }
}
