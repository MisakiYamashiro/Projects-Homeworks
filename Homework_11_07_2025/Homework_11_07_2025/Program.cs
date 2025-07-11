using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Her koleksiyon bir sınıf. her koleksiyona en az 10 öğrenci kaydedilecek en az 3 sınıf olacak ve listeleyecez YAPILDI.
            //Kitaplık koleksiyonu kitaplağımızdaki bütün kitapları yazar yayınevi kitabın adi ve sayfa sayısı listeleyecek YAPILDI.

            #region Öğrenciler
            Koleksiyon sinif = new Koleksiyon();
            sinif.Ekle("Ali", "Yılmaz", 15, 540, 1);
            sinif.Ekle("Ayşe", "Demir", 16, 541, 1);
            sinif.Ekle("Mehmet", "Kara", 15, 542, 1);
            sinif.Ekle("Fatma", "Çelik", 17, 543, 1);
            sinif.Ekle("Ahmet", "Koç", 16, 544, 1);
            sinif.Ekle("Zeynep", "Aydın", 15, 545, 1);
            sinif.Ekle("Emre", "Polat", 16, 546, 1);
            sinif.Ekle("Elif", "Öztürk", 15, 547, 1);
            sinif.Ekle("Can", "Yavuz", 17, 548, 1);
            sinif.Ekle("Ece", "Kaya", 16, 549, 1);
            sinif.Ekle("Deniz", "Arslan", 15, 550, 2);
            sinif.Ekle("Burak", "Tekin", 16, 551, 2);
            sinif.Ekle("Selin", "Yıldız", 15, 552, 2);
            sinif.Ekle("Cem", "Güneş", 17, 553, 2);
            sinif.Ekle("Seda", "Akman", 16, 554, 2);
            sinif.Ekle("Oğuz", "Kara", 15, 555, 2);
            sinif.Ekle("Derya", "Sönmez", 16, 556, 2);
            sinif.Ekle("Mert", "Polat", 15, 557, 2);
            sinif.Ekle("Seda", "Yılmaz", 17, 558, 2);
            sinif.Ekle("Cem", "Koç", 16, 559, 2);
            sinif.Ekle("Ali", "Yılmaz", 15, 560, 3);
            sinif.Ekle("Ayşe", "Demir", 16, 561, 3);
            sinif.Ekle("Mehmet", "Kara", 15, 562, 3);
            sinif.Ekle("Fatma", "Çelik", 17, 563, 3);
            sinif.Ekle("Ahmet", "Koç", 16, 564, 3);
            sinif.Ekle("Zeynep", "Aydın", 15, 565, 3);
            sinif.Ekle("Emre", "Polat", 16, 566, 3);
            sinif.Ekle("Elif", "Öztürk", 15, 567, 3);
            sinif.Ekle("Can", "Yavuz", 17, 568, 3);
            sinif.Ekle("Ece", "Kaya", 16, 569, 3);




            #endregion

            //sinif.Listele();

            #region Kitaplık 
            Kitaplik kitaplik = new Kitaplik();
            kitaplik.Ekle("Atatürk", "İlber Ortaylı", "Kronik Kitap", 416);
            kitaplik.Ekle("Avrupa Tarihi", "Önder Kaya", "Timaş Yayınları", 336);
            kitaplik.Ekle("Birinci Dünya Savaşı Resimlerle", "Andrew Wiest", "Kronik Kitap", 336);
            kitaplik.Ekle("İkinci Dünya Savaşı Resimlerle", "John Walton ve Owen Booth", "Kronik Kitap", 328);
            kitaplik.Ekle("Canavar Peşinde 1", "Adam Blade", "Beyaz Balina Yayınları", 136);
            kitaplik.Ekle("Canavar Peşinde 2", "Adam Blade", "Beyaz Balina Yayınları", 136);
            kitaplik.Ekle("Canavar Peşinde 3", "Adam Blade", "Beyaz Balina Yayınları", 136);
            kitaplik.Ekle("Canavar Peşinde 4", "Adam Blade", "Beyaz Balina Yayınları", 136);
            kitaplik.Ekle("Canavar Peşinde 5", "Adam Blade", "Beyaz Balina Yayınları", 136);
            kitaplik.Ekle("Saftirik Greg'in Günlüğü 1", "Jeff Kinney", "Epsilon Yayınevi", 224);
            kitaplik.Ekle("Saftirik Greg'in Günlüğü 2", "Jeff Kinney", "Epsilon Yayınevi", 224);
            kitaplik.Ekle("Saftirik Greg'in Günlüğü 3", "Jeff Kinney", "Epsilon Yayınevi", 224);
            kitaplik.Ekle("Saftirik Greg'in Günlüğü 4", "Jeff Kinney", "Epsilon Yayınevi", 224);
            kitaplik.Ekle("Şehirler Tarihi", "İlber Ortaylı", "İnkılap Kitabevi", 156);
            kitaplik.Ekle("Kısa Dünya Tarihi", "Merry E. Wiesner-Hanks", "İş Bankası Kültür Yayınları", 448);
            kitaplik.Ekle("Aptalı Tanımak", "A. M. Celal Şengör", "Ka Kitap", 200);
            kitaplik.Ekle("Bir Bilim Adamının Serüveni", "A. M. Celal Şengör", "İş Bankası Kültür Yayınları", 675);
            kitaplik.Ekle("Bir Toplum Nasıl İntihar Eder?", "A. M. Celal Şengör", "Ka Kitap", 189);
            kitaplik.Ekle("Bilgiyle Sohbet", "A. M. Celal Şengör", "İş Bankası Kültür Yayınları", 792);
            kitaplik.Ekle("Bilimin Büyüsü", "A. M. Celal Şengör", "İnkılap Kitabevi", 160);
            kitaplik.Ekle("Cehaletten Kurtulma Sanatı - Kim Kimdir?", "A. M. Celal Şengör", "Masa Kitap", 188);
            kitaplik.Ekle("Cehennemdeki Üniversiteliler", "A. M. Celal Şengör", "Masa Kitap", 248);
            kitaplik.Ekle("Dahi Diktatör", "A. M. Celal Şengör", "Ka Kitap", 136);
            kitaplik.Ekle("Dikkate Değer Mevzular", "A. M. Celal Şengör", "İnkılap Kitabevi", 136);
            kitaplik.Ekle("Hasan Ali Yücel ve Türk Aydınlanması", "A. M. Celal Şengör", "İş Bankası Kültür Yayınları", 192);
            kitaplik.Ekle("Jeolojinin Eduard Suess'e Kadarki Kısa Tarihi", "A. M. Celal Şengör", "İTÜ Vakfı Yayınları", 144);
            kitaplik.Ekle("Newton Neden Türk Değildi?", "A. M. Celal Şengör", "Ka Kitap", 192);
            kitaplik.Ekle("Senin Cahilliğin Benim Yaşamımı Etkiliyor", "A. M. Celal Şengör", "Masa Kitap", 260);
            kitaplik.Ekle("Yaşamın Evrimi Fikrinin Darwin Döneminin Sonuna Kadarki Kısa Tarihi", "A. M. Celal Şengör", "İTÜ Vakfı Yayınları", 190);
            kitaplik.Ekle("Zümrüt Ayna", "A. M. Celal Şengör", "İnkılap Kitabevi", 224);
            kitaplik.Ekle("Zümrütname", "A. M. Celal Şengör", "Ka Kitap", 220);
            kitaplik.Ekle("99 Sayfada İstanbul Depremi", "A. M. Celal Şengör", "İş Bankası Kültür Yayınları", 109);
            kitaplik.Ekle("Aforizmalar", "A. M. Celal Şengör", "Masa Kitap", 112);
            #endregion

            kitaplik.Listele();
            



        }
    }
}
