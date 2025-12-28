using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oğrenci_Otomasyonu
{
    internal class Metodlar
    {
        public  static string GetString(string metin,int min,int max)
        {
            string unal=string.Empty;
            bool hata=false;


            do
            {
                Console.Write(metin);
                unal = Console.ReadLine();
                if (string.IsNullOrEmpty(unal))
                {
                    Console.WriteLine("Boş Değer Girilemez");
                    hata = true;
                }
                else
                {
                    if (unal.Length<min || unal.Length>max)
                    {
                        Console.WriteLine("Lütfen min.{0},max.{1} uzunlukta bir metin giriniz", min, max);
                    }
                    else
                    {
                        hata=false ;
                    }
                }
            }
            while (hata);



            return unal;


        }


        public static int GetInt(string metin,int min,int max)
        {
            int sayi = 0;
            bool hata=false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi>=min&&sayi<=max)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0],max{1} arasında bir değer giriniz",min,max);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    hata = true;
                }
                
            }
            while (hata);
            return sayi;
        }



        public static double GetDuoble(string metin,double min=double.MinValue,double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata=false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi=double.Parse(Console.ReadLine());
                    if (sayi>=min&&sayi<=max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0],max{1} arasında bir değer giriniz", min, max);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine (ex.Message);
                    hata = true;
                }
                
            }
            while (hata);
            return sayi;
        }



        public static DateTime GetDateTime(string metin,int minYear,int maxYear)
        {
            DateTime tarih=DateTime.Now;
            bool hata=false;
            do
            {
                Console.Write(metin);
                try
                {
                    tarih=DateTime.Parse(Console.ReadLine());
                    if (tarih.Year>=minYear && tarih.Year<=maxYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} yılları arasında bir tarih giriniz",minYear,maxYear);
                        hata=true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    hata=true;
                }
            }
            while (hata);

            return tarih;
        }

















    }
}
