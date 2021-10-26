using System;

namespace OdevNeseYonelimliProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {

            Okul.Okul okul = new Okul.Okul();
            okul.Sınıf();
            
            
            Okul.Sınıf sınıf = new Okul.Sınıf();
            sınıf.Ogrenci();

            Matemtik.Mat mat = new Matemtik.Mat();
            mat.Mate();

            Matemtik.Mate2 mat2 = new Matemtik.Mate2();
            mat2.Matek();

            //****** hesap makinesini çalıştırmaya çalıştım çalıştıramadım******

           /* HesapMak.HesapMakinası hes = new HesapMak.HesapMakinası();
            hes.*/
            


            
            Console.Read();

        }
    }

    
}
namespace Okul
{
   public class Okul
   {
        public void Sınıf()
        {
            Console.WriteLine("");
        }
   }

   public class Sınıf:Okul
   {
        public void Ogrenci()
        {
            Console.WriteLine("Okul > Sınıf > Ogrenci");
        }
   }

    
}

namespace Matemtik
{
    public class Mat:Mate2
    {
        public void Mate()
        {

            Console.WriteLine("İki değer giriniz :");
            double deger1 = Convert.ToDouble(Console.ReadLine());
            double deger2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = deger1 + deger2;
            Console.WriteLine($"sonuc : " + sonuc);

        }
    }

    public class Mate2
    {
       public void Matek()
        {
            Console.WriteLine("İki değer giriniz :");
            double deger1 = Convert.ToDouble(Console.ReadLine());
            double deger2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = deger1 - deger2;
            Console.WriteLine($"sonuc : " + sonuc);
        }
    }
       


}


