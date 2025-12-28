namespace Oğrenci_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ÖĞRENCİ KAYIT OTOMASYONU
            //1-Öğrenci Ekle
            //2-Öğrencileri Listele
            //3-Öğrenci Sil
            //4-Öğrencilerin Gnel Not Ortlaması
            //5-Öğrencilerin Yaş Ortlaması
            //6-Öğrenci Sayısı
            //0-Çıkış




            //Ad                      string
            //Soyad                   string
            //N1                      double
            //N2                      double
            //DogumTarihi             
            ConsoleKey cevap;

            do
            {
                Console.Clear();
                Console.WriteLine("ÖĞRENCİ kAYIT OTMASYONU:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1-ÖĞrenci Ekle");
                Console.WriteLine("2-ÖĞrenci Listesi");
                Console.WriteLine("3-ÖĞrenci Sil");
                Console.WriteLine("4-ÖĞrencilerin Genel Net Ortalaması");
                Console.WriteLine("5-ÖĞrencilerin Yaş Ortalması");
                Console.WriteLine("6-ÖĞrenci Sayısı");
                Console.WriteLine("0-Çıkış");
                Console.WriteLine();
                Console.Write("Hangi İşlemi Yapmak İstersiniz?:");
                cevap=Console.ReadKey().Key;

                Menu.Islemler(cevap);

            }
            while (cevap!=ConsoleKey.NumPad0 && cevap!=ConsoleKey.D0);
            Console.Clear() ;
            Console.WriteLine("Programı Kulandığınız İçin Teşekür ederiz");
            Console.WriteLine("Kapatamak İçin bir Tuşa Basınız");
            






























            Console.ReadKey();

        }
    }
}
