using System;
using System.Collections;

namespace Odev
{
    class Program
    {
        //odev1
        public static bool asalKontrol (uint sayi)
        {
            bool durum = false;
            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    kontrol = 1;
                    break;
                }
            }

            if (kontrol == 1 || sayi == 0 || sayi == 1)
           durum = false;

           else
           durum = true;

           return durum;

        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz");
            ArrayList A_sayilar = new ArrayList();
            ArrayList A_olmayan = new ArrayList();

            try
            {
                for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i +". Sayıyı Giriniz");
                uint sayim = uint.Parse(Console.ReadLine());
                if(asalKontrol(sayim))
                {
                    A_sayilar.Add(sayim);
                }
                else
                A_olmayan.Add(sayim);
            }
            }
            catch (Exception hata)
            {
             Console.WriteLine("Lütfen Pozitif Sayı Giriniz");
             Console.WriteLine("hata: "+hata.Message.ToString());
            }
            
            A_sayilar.Sort();
            A_olmayan.Sort();
            A_sayilar.Reverse();
            A_olmayan.Reverse();
            Console.Write("Asal Sayılar = ");
            foreach (var item in A_sayilar)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
             Console.Write("Asal Olmayan Sayılar = ");
            foreach (var item in A_olmayan)
            {
                 Console.Write(item+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Asal Sayıların Adeti = "+A_sayilar.Count+" Tanedir");
            Console.WriteLine("Asal Olmayanların Adeti = "+A_olmayan.Count+" Tanedir");
            uint A_Toplam = 0;
            uint A_olmayantoplam = 0;

            for (int i = 0; i < A_sayilar.Count; i++)
            {
                A_Toplam +=(uint) A_sayilar[i];
            }

             for (int i = 0; i < A_olmayan.Count; i++)
            {
                A_olmayantoplam +=(uint) A_olmayan[i];
            }

            Console.WriteLine("Asal Sayıların Ortamalası = "+ A_Toplam/A_sayilar.Count);
            Console.WriteLine("Asal Olmayanların Ortamalası = "+ A_olmayantoplam/A_olmayan.Count);

        //odev 2
            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz");
            ArrayList sayilar = new ArrayList();
            for (int m = 0; m < 20; m++)
            {   
                Console.WriteLine($"Lütfen {m+1}. Sayiyi Giriniz");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            sayilar.Sort();
            ArrayList bSayilar = new ArrayList();
            ArrayList kSayilar = new ArrayList();
            int sayiuzunlugu = sayilar.Count;
            for (int i = 0; i < 3; i++)
            {
                kSayilar.Add((int)sayilar[i]);
            }
             for (int i = sayilar.Count-3; i < sayilar.Count; i++)
            {
                bSayilar.Add((int)sayilar[--sayiuzunlugu]);
            }
            Console.Write("İlk 3 Sayi =");
            foreach (var item in kSayilar)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
             Console.Write("Son 3 Sayi =");
            foreach (var item in bSayilar)
            {
                Console.Write(" "+item);
            }
            int kSayilartoplam = 0;
            for (int i = 0; i < kSayilar.Count; i++)
            {
                kSayilartoplam += (int)kSayilar[i];
            }
            Console.WriteLine("Küçük Sayıların Toplamı = " + kSayilartoplam);
            int bSayilartoplam = 0;
            for (int i = 0; i < bSayilar.Count; i++)
            {
                bSayilartoplam += (int)bSayilar[i];
            }
            Console.WriteLine("Büyük Sayıların Toplamı = " + bSayilartoplam);

            int kOrtalama = kSayilartoplam/kSayilar.Count;
            int bOrtalama = bSayilartoplam/bSayilar.Count;

            Console.WriteLine("Küyük Sayıların Ortalaması = " + kOrtalama);
            Console.WriteLine("Büyük Sayıların Ortalaması = " + bOrtalama);
            Console.WriteLine("Ortalama Toplamı = " + (kOrtalama+bOrtalama));

            Console.WriteLine("Lütfen Bir Cümle Giriniz");
            string cumle = Console.ReadLine();

            ArrayList sesliHarfler = new ArrayList();
            string kontrol = "aeıioöuü";

            for (int i = 0; i < cumle.Length; i++)
            {
                if (kontrol.Contains(cumle[i]))
                {
                    sesliHarfler.Add(cumle[i]);
                }
            }

            foreach (var item in sesliHarfler)
            {
                Console.Write(item+"-");
            }
        }
    }
}