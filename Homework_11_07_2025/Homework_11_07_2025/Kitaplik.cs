using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_2025
{
    internal class Kitaplik
    {
        Kitaplik[] kitaplar;

        public string KitapAdi { get; set; }    
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public int SayfaSayisi { get; set; }
        public Kitaplik()
        {
            kitaplar = new Kitaplik[0];
        }

        public void Ekle(Kitaplik kitap)
        {
            Kitaplik[] gecici = new Kitaplik[kitaplar.Length + 1];
            Array.Copy(kitaplar, gecici, kitaplar.Length);
            gecici[gecici.Length - 1] = kitap;
            kitaplar = gecici;
        }
        public void Ekle(string kitapAdi, string yazar, string yayinevi, int sayfaSayisi)
        {
            Kitaplik kitap = new Kitaplik();
            kitap.KitapAdi = kitapAdi;
            kitap.Yazar = yazar;
            kitap.Yayinevi = yayinevi;
            kitap.SayfaSayisi = sayfaSayisi;
            // ---
            Kitaplik[] gecici = new Kitaplik[kitaplar.Length + 1];
            Array.Copy(kitaplar, gecici, kitaplar.Length);
            gecici[gecici.Length - 1] = kitap;
            kitaplar = gecici;
        }
        public void Listele()
        {
            Console.WriteLine("Kitap Listesi");
            Console.WriteLine("-------------");
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Kitaplik listele = kitaplar[i];
                Console.WriteLine($"{i + 1}. Kitap: Kitap Adı: {listele.KitapAdi}, Yazar: {listele.Yazar}, Yayın Evi: {listele.Yayinevi}, Sayfa Sayısı: {listele.SayfaSayisi}");
            }
        }
        
    }
}
