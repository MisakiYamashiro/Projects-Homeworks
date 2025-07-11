using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_2025
{
    internal class Koleksiyon
    {
        Koleksiyon[] sinif1;
        Koleksiyon[] sinif2;
        Koleksiyon[] sinif3;

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public int No { get; set; }
        public int SinifNo { get; set; }
        public Koleksiyon()
        {
            sinif1 = new Koleksiyon[0];
            sinif2 = new Koleksiyon[0];
            sinif3 = new Koleksiyon[0];
        }
        public void Ekle(string isim, string soyisim, int yas, int no, int sinifNo)
        {
            Koleksiyon ogrenci = new Koleksiyon();
            ogrenci.Isim = isim;
            ogrenci.Soyisim = soyisim;
            ogrenci.Yas = yas;
            ogrenci.No = no;
            ogrenci.SinifNo = sinifNo;

            if (sinifNo == 1)
            {
                Koleksiyon[] gecici = new Koleksiyon[sinif1.Length + 1];
                Array.Copy(sinif1, gecici, sinif1.Length);
                gecici[gecici.Length - 1] = ogrenci;
                sinif1 = gecici;
            }
            else if (sinifNo == 2)
            {
                Koleksiyon[] gecici = new Koleksiyon[sinif2.Length + 1];
                Array.Copy(sinif2, gecici, sinif2.Length);
                gecici[gecici.Length - 1] = ogrenci;
                sinif2 = gecici;
            }
            else if (sinifNo == 3)
            {
                Koleksiyon[] gecici = new Koleksiyon[sinif3.Length + 1];
                Array.Copy(sinif3, gecici, sinif3.Length);
                gecici[gecici.Length - 1] = ogrenci;
                sinif3 = gecici;
            }   

        }
        public void Ekle(Koleksiyon ogrenci)
        {
            Ekle(ogrenci.Isim, ogrenci.Soyisim, ogrenci.Yas, ogrenci.No, ogrenci.SinifNo);
        }
        public void Listele()
        {
            Console.WriteLine("Sınıf 1 Öğrencileri:");
            foreach (var ogrenci in sinif1)
            {
                Console.WriteLine($"No: {ogrenci.No}, İsim: {ogrenci.Isim}, Soyisim: {ogrenci.Soyisim}, Yaş: {ogrenci.Yas}");
            }
            Console.WriteLine("Sınıf 2 Öğrencileri:");
            foreach (var ogrenci in sinif2)
            {
                Console.WriteLine($"No: {ogrenci.No}, İsim: {ogrenci.Isim}, Soyisim: {ogrenci.Soyisim}, Yaş: {ogrenci.Yas}");
            }
            Console.WriteLine("Sınıf 3 Öğrencileri:");
            foreach (var ogrenci in sinif3)
            {
                Console.WriteLine($"No: {ogrenci.No}, İsim: {ogrenci.Isim}, Soyisim: {ogrenci.Soyisim}, Yaş: {ogrenci.Yas}");
            }
        }
    }
}
