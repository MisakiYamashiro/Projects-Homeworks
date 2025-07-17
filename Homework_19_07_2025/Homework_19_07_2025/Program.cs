using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_07_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En az 25 adet kitap olucak

            //1-Türe Göre
            //2- Yayınevine Göre
            //3- İsme göre(3 karakter yeterli)
            //4- Tümü
            //5- Kiradakileri listele.

            //1,2,3,4'te kiradakiler listelenmeyecek!!

            //Kitap seçilip kiralanabilecek.
            //Sistemden çık diyene kadar devam edecek
            #region Kitaplar
            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(new Kitap { Isim = "Suç ve Ceza", Yazar = "Fyodor Dostoyevski", YayinEvi = "Can Yayınları", SayfaSayisi = 672, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "1984", Yazar = "George Orwell", YayinEvi = "İthaki Yayınları", SayfaSayisi = 352, Tur = "Distopya", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Sefiller", Yazar = "Victor Hugo", YayinEvi = "İş Bankası Kültür Yayınları", SayfaSayisi = 1488, Tur = "Roman", KiradaMi = true });
            kitaplar.Add(new Kitap { Isim = "Yüzüklerin Efendisi", Yazar = "J.R.R. Tolkien", YayinEvi = "Metis Yayınları", SayfaSayisi = 1136, Tur = "Fantastik", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Dune", Yazar = "Frank Herbert", YayinEvi = "Kabalcı Yayınevi", SayfaSayisi = 784, Tur = "Bilim Kurgu", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Simyacı", Yazar = "Paulo Coelho", YayinEvi = "Can Yayınları", SayfaSayisi = 184, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Cesur Yeni Dünya", Yazar = "Aldous Huxley", YayinEvi = "İthaki Yayınları", SayfaSayisi = 272, Tur = "Distopya", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Bilinmeyen Bir Kadının Mektubu", Yazar = "Stefan Zweig", YayinEvi = "Türkiye İş Bankası", SayfaSayisi = 80, Tur = "Novella", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Harry Potter ve Felsefe Taşı", Yazar = "J.K. Rowling", YayinEvi = "Yapı Kredi Yayınları", SayfaSayisi = 280, Tur = "Fantastik", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Küçük Prens", Yazar = "Antoine de Saint-Exupéry", YayinEvi = "Mavibulut Yayınları", SayfaSayisi = 112, Tur = "Çocuk", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Saatleri Ayar Etme Enstitüsü", Yazar = "Ahmet Hamdi Tanpınar", YayinEvi = "Dergah Yayınları", SayfaSayisi = 382, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Otostopçunun Galaksi Rehberi", Yazar = "Douglas Adams", YayinEvi = "Kabalcı Yayınevi", SayfaSayisi = 208, Tur = "Bilim Kurgu", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", YayinEvi = "Yapı Kredi Yayınları", SayfaSayisi = 160, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Aşk ve Gurur", Yazar = "Jane Austen", YayinEvi = "Can Yayınları", SayfaSayisi = 432, Tur = "Romantik", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Bülbülü Öldürmek", Yazar = "Harper Lee", YayinEvi = "Sel Yayıncılık", SayfaSayisi = 336, Tur = "Roman", KiradaMi = true });
            kitaplar.Add(new Kitap { Isim = "Uçurtma Avcısı", Yazar = "Khaled Hosseini", YayinEvi = "Everest Yayınları", SayfaSayisi = 424, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Yeraltından Notlar", Yazar = "Fyodor Dostoyevski", YayinEvi = "Can Yayınları", SayfaSayisi = 160, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Anna Karenina", Yazar = "Lev Tolstoy", YayinEvi = "İletişim Yayınları", SayfaSayisi = 960, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Fahrenheit 451", Yazar = "Ray Bradbury", YayinEvi = "İthaki Yayınları", SayfaSayisi = 256, Tur = "Distopya", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Martı Jonathan Livingston", Yazar = "Richard Bach", YayinEvi = "Epsilon Yayınevi", SayfaSayisi = 112, Tur = "Felsefi", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Çöldeki Çiçek", Yazar = "Waris Dirie", YayinEvi = "Koridor Yayıncılık", SayfaSayisi = 240, Tur = "Biyografi", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Sisifos Söyleni", Yazar = "Albert Camus", YayinEvi = "Can Yayınları", SayfaSayisi = 152, Tur = "Felsefe", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Hobbit", Yazar = "J.R.R. Tolkien", YayinEvi = "İthaki Yayınları", SayfaSayisi = 304, Tur = "Fantastik", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Don Kişot", Yazar = "Miguel de Cervantes", YayinEvi = "Yapı Kredi Yayınları", SayfaSayisi = 992, Tur = "Roman", KiradaMi = false });
            kitaplar.Add(new Kitap { Isim = "Frankenstein", Yazar = "Mary Shelley", YayinEvi = "İthaki Yayınları", SayfaSayisi = 280, Tur = "Gotik", KiradaMi = true });
            string[] turler = {"Roman", "Distopya", "Fantastik", "Bilim Kurgu", "Çocuk", "Novella", "Romantik", "Felsefi", "Biyografi", "Felsefe", "Gotik"
            };
            string[] yayinevleri = {"Can Yayınları", "İthaki Yayınları", "İş Bankası Kültür Yayınları", "Metis Yayınları", "Kabalcı Yayınevi", "Yapı Kredi Yayınları", "Mavibulut Yayınları", "Dergah Yayınları", "Sel Yayıncılık", "Everest Yayınları", "İletişim Yayınları", "Epsilon Yayınevi", "Koridor Yayıncılık"
            };
            #endregion
            List<Kitap> kiralananKitaplar = new List<Kitap>();
            string secenek = "e";
            while (secenek == "e") 
            {
                Console.Clear();
                Console.WriteLine("1- Türe Göre");
                Console.WriteLine("2- Yayınevine Göre");
                Console.WriteLine("3- İsme göre (3 karakter yeterli)");
                Console.WriteLine("4- Tümü");
                Console.WriteLine("5- Kiradakileri listele");
                Console.WriteLine("6- Çıkış");
                secenek = Console.ReadLine();
                switch (secenek)
                {
                    case "1":
                        Console.Clear();
                        for (int i = 0; i < turler.Length; i++)
                        {
                            Console.WriteLine(turler[i]);
                        }
                        Console.WriteLine("---------------");
                        Console.WriteLine("İstediğiniz bir tür yazınız : ");
                        string tur = Console.ReadLine();
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            if (tur == kitaplar[i].Tur)
                            {

                                if (!kitaplar[i].KiradaMi)
                                {
                                    Console.WriteLine($"{i}) Kitap:" +
                                        $" İsim: {kitaplar[i].Isim}," +
                                        $" Yazar: {kitaplar[i].Yazar}," +
                                        $" Yayın Evi: {kitaplar[i].YayinEvi}," +
                                        $" Sayfa Sayısı: {kitaplar[i].SayfaSayisi}," +
                                        $" Tür: {kitaplar[i].Tur}," +
                                        $" Kirada Mı: {kitaplar[i].KiradaMi} \n");
                                    
                                }
                            }
                        }
                        string secenek2 = "e";
                        Console.WriteLine("Kitap Kiralamak İstiyor Musunuz? e/h");
                        secenek2 = Console.ReadLine();
                        if (secenek2.ToLower() == "e")
                        {
                            Console.WriteLine("Kiralamak istediğiniz kitabın index numarasını girin : ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (kitaplar[index].KiradaMi == true)
                            {
                                Console.WriteLine("Kitap Zaten Kirada.");
                                return;
                            }
                            else
                            {
                                if (index < 0 || index >= kitaplar.Count)
                                {
                                    Console.WriteLine("Geçersiz index numarası.");
                                    return;
                                }
                                kiralananKitaplar.Add(kitaplar[index]);
                                Console.WriteLine("Kitabınız Kiralandı.");
                                kitaplar[index].KiradaMi = true;
                            }
                        }
                        else
                        {
                            

                        }
                        Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                        secenek = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        for (int i = 0; i < yayinevleri.Length; i++)
                        {
                            Console.WriteLine(yayinevleri[i]);
                        }
                        Console.WriteLine("---------------");
                        Console.WriteLine("İstediğiniz bir tür yazınız : ");
                        string yayinevi = Console.ReadLine();
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            if (kitaplar[i].YayinEvi == yayinevi)
                            {

                                if (!kitaplar[i].KiradaMi)
                                {
                                    Console.WriteLine($"{i + 1}) Kitap:" +
                                        $" İsim: {kitaplar[i].Isim}," +
                                        $" Yazar: {kitaplar[i].Yazar}," +
                                        $" Yayın Evi: {kitaplar[i].YayinEvi}," +
                                        $" Sayfa Sayısı: {kitaplar[i].SayfaSayisi}," +
                                        $" Tür: {kitaplar[i].Tur}," +
                                        $" Kirada Mı: {kitaplar[i].KiradaMi} \n");
                                    
                                }


                            }
                            else
                            {
                                Console.WriteLine("Geçersiz Yayın Evi");
                                break;
                            }

                        }
                        string secenek3 = "e";
                        Console.WriteLine("Kitap Kiralamak İstiyor Musunuz? e/h");
                        secenek3 = Console.ReadLine();
                        if (secenek3.ToLower() == "e")
                        {
                            Console.WriteLine("Kiralamak istediğiniz kitabın index numarasını girin : ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (kitaplar[index].KiradaMi == true)
                            {
                                Console.WriteLine("Kitap Zaten Kirada.");
                                return;
                            }
                            else
                            {
                                if (index < 0 || index >= kitaplar.Count)
                                {
                                    Console.WriteLine("Geçersiz index numarası.");
                                    return;
                                }
                                kiralananKitaplar.Add(kitaplar[index]);
                                Console.WriteLine("Kitabınız Kiralandı.");
                                kitaplar[index].KiradaMi = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                            secenek = Console.ReadLine();

                        }
                        break;
                    case "3":
                        Console.WriteLine("İstediğiniz kitabın ismini giriniz");
                        string isim = Console.ReadLine();
                        if (isim.Length < 3)
                        {
                            Console.WriteLine("Lütfen en az 3 karakter giriniz.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < kitaplar.Count; i++)
                            {
                                if (kitaplar[i].Isim.Contains(isim))
                                {
                                    Console.WriteLine($"{i + 1}) Kitap:" +
                                       $" İsim: {kitaplar[i].Isim}," +
                                       $" Yazar: {kitaplar[i].Yazar}," +
                                       $" Yayın Evi: {kitaplar[i].YayinEvi}," +
                                       $" Sayfa Sayısı: {kitaplar[i].SayfaSayisi}," +
                                       $" Tür: {kitaplar[i].Tur}," +
                                       $" Kirada Mı: {kitaplar[i].KiradaMi}\n");

                                    
                                }
                            }
                        }
                        string secenek4 = "e";
                        Console.WriteLine("Kitap Kiralamak İstiyor Musunuz? e/h");
                        secenek4 = Console.ReadLine();
                        if (secenek4.ToLower() == "e")
                        {
                            Console.WriteLine("Kiralamak istediğiniz kitabın index numarasını girin : ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (kitaplar[index].KiradaMi == true)
                            {
                                Console.WriteLine("Kitap Zaten Kirada.");
                                return;
                            }
                            else
                            {
                                if (index < 0 || index >= kitaplar.Count)
                                {
                                    Console.WriteLine("Geçersiz index numarası.");
                                    return;
                                }
                                kiralananKitaplar.Add(kitaplar[index]);
                                Console.WriteLine("Kitabınız Kiralandı.");
                                kitaplar[index].KiradaMi = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                            secenek = Console.ReadLine();

                        }
                        break;
                    case "4":
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) Kitap:" +
                                       $" İsim: {kitaplar[i].Isim}," +
                                       $" Yazar: {kitaplar[i].Yazar}," +
                                       $" Yayın Evi: {kitaplar[i].YayinEvi}," +
                                       $" Sayfa Sayısı: {kitaplar[i].SayfaSayisi}," +
                                       $" Tür: {kitaplar[i].Tur}," +
                                       $" Kirada Mı: {kitaplar[i].KiradaMi}\n");
                            Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                            secenek = Console.ReadLine();
                        }
                        string secenek5 = "e";
                        Console.WriteLine("Kitap Kiralamak İstiyor Musunuz? e/h");
                        secenek5 = Console.ReadLine();
                        if (secenek5.ToLower() == "e")
                        {
                            Console.WriteLine("Kiralamak istediğiniz kitabın index numarasını girin : ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (kitaplar[index].KiradaMi == true)
                            {
                                Console.WriteLine("Kitap Zaten Kirada.");
                                return;
                            }
                            else
                            {
                                if (index < 0 || index >= kitaplar.Count)
                                {
                                    Console.WriteLine("Geçersiz index numarası.");
                                    return;
                                }
                                kiralananKitaplar.Add(kitaplar[index]);
                                Console.WriteLine("Kitabınız Kiralandı.");
                                kitaplar[index].KiradaMi = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                            secenek = Console.ReadLine();

                        }
                        break;
                    case "5":
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            if (kitaplar[i].KiradaMi == true)
                            {
                                Console.WriteLine($"{i + 1}) Kitap:" +
                                       $" İsim: {kitaplar[i].Isim}," +
                                       $" Yazar: {kitaplar[i].Yazar}," +
                                       $" Yayın Evi: {kitaplar[i].YayinEvi}," +
                                       $" Sayfa Sayısı: {kitaplar[i].SayfaSayisi}," +
                                       $" Tür: {kitaplar[i].Tur}," +
                                       $" Kirada Mı: {kitaplar[i].KiradaMi}\n");


                            }
                        }
                        Console.WriteLine("Devam Etmek İster Misiniz? e/h");
                        secenek = Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Sistemden çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçenek, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
    
}
