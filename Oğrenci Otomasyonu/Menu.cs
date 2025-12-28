using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oğrenci_Otomasyonu
{
    internal class Menu
    {
        static List<Ogrenci>ogrenciler=new();
        public static void Islemler(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Ekle("ÖĞRENCİ EKLE");

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Listele("ÖĞRENCİ LİSTESİ");
                    break;
                 case ConsoleKey.NumPad3:
                 case ConsoleKey.D3:
                    Sil("ÖĞRENCİ SİL");
                    break;
                 case ConsoleKey.NumPad4:
                 case ConsoleKey.D4:
                     NotOrtlamasi("ÖĞRENCİLERİN GENEL NOT ORTLAMASI");
                    break;
                  case ConsoleKey.NumPad5:
                  case ConsoleKey.D5:
                    YasOrtalamasi("ÖĞRENCİLERİN YAŞ ORTALMASI");
                    break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                    OgrenciSayisi("TOPLAM ÖĞRENCİLERİN SAYISI");
                    break;




                   
            }
        }

        private static void OgrenciSayisi(string v)
        {
            BaslikYazdır(v);
            if (ogrenciler.Any())
            {
                AnaMenuyeDön(string.Format("Listede {0} öğrenci kayıtlıdır",ogrenciler.Count()));
            }
            else
            {
                AnaMenuyeDön("Listede Öğrenci Bulunmamaktadır");
            }
        }

        private static void YasOrtalamasi(string v)
        {
            BaslikYazdır(v);
            if (ogrenciler.Any())
            {
                double yasOrtlaması = 0;
                foreach (var ogr in ogrenciler)
                {
                    yasOrtlaması += ogr.Yas;

                }
                yasOrtlaması/=ogrenciler.Count();
                AnaMenuyeDön(string.Format("{0} öğrencinin yaş ortlaması:{1}",ogrenciler.Count,Math.Round(yasOrtlaması,2)));
            }
            else
            {
                AnaMenuyeDön("Listede Öğrenci Bulunmamaktadır");
            }
        }

        private static void NotOrtlamasi(string v)
        {
            BaslikYazdır(v);
            if (ogrenciler.Any())
            {
                double genelOrtalama = 0;
                foreach (var ogr in ogrenciler)
                {
                    genelOrtalama += ogr.Ortalama;  
                }
                genelOrtalama/=ogrenciler.Count();
                AnaMenuyeDön(string.Format("{0} Öğrencinin not ortalması:{1}",ogrenciler.Count,Math.Round(genelOrtalama,2)));
            }
            else
            {
                AnaMenuyeDön("Listede Öğrenci Bulunmamaktadır");
            }
        }

        private static void Sil(string v)
        {
            BaslikYazdır(v);
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);

                }
                Console.WriteLine();
                int siraNo=Metodlar.GetInt("Silmek İstediğiniz Öğrencinin Sıra Numarası girirniz:",1,ogrenciler.Count);
                int indexNo = siraNo - 1;
                string silinecek = ogrenciler[indexNo].TamAd;
                Console.WriteLine("{0} isimli öğrenciyi silmek istediğinize emin misiniz?(e)",silinecek);
                if (Console.ReadKey().Key==ConsoleKey.E)
                {
                    ogrenciler.RemoveAt(indexNo);
                    AnaMenuyeDön(string.Format("{0} isimli öğrenci listeden silinmiştir", silinecek));

                }
                else
                {
                    AnaMenuyeDön("Silme İşlemi İptal Edildi");
                }

            }
            else
            {
                AnaMenuyeDön("Listede Öğrenciler Bulnmamaktadır.");
            }
        }

        private static void Listele(string v)
        {
            BaslikYazdır(v);
            if (ogrenciler.Any())
            {
                
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                AnaMenuyeDön(string.Format("{0} Öğrenci Listelenmiştir", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDön("Listede Öğrenci  Bulunmamaktadır.");
            }
        }

        private static void Ekle(string v)
        {
            BaslikYazdır(v);
            Ogrenci o=new();
            o.Ad = Metodlar.GetString("Öğrenci Adı:", 2, 20);
            o.Soyad = Metodlar.GetString("Öğrenci Soyadı:", 2, 20);
            o.N1 = Metodlar.GetDuoble("1.Not:", 0, 100);
            o.N2 = Metodlar.GetDuoble("2.Not:", 0, 100);
            o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi:", DateTime.Now.AddYears(-40).Year, DateTime.Now.AddYears(-16).Year);
            ogrenciler.Add(o);
            AnaMenuyeDön(string.Format("{0} Öğrencisi Listeye başarılıyla eklendi",o.TamAd ) );
                

        }
        private static void BaslikYazdır(string v)
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }
        private static void AnaMenuyeDön(string v)
        {
            
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
            Console.ReadKey();
        }
        
    }
}
