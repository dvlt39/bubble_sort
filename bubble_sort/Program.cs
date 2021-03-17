using System;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, baslangic = 0;
            // kullanicidan kac adet sayi gireceginiz soracagiz
            Console.WriteLine("Kac adet sayi girmek istiyorsunuz?");
            sayi = Convert.ToInt32(Console.ReadLine());

            // bu alanda bir array belirliyoruz ve uzunluguna az once kullanicidan almis oldugumuz degeri atiyoruz
            int[] sayilar = new int[sayi];

            // array'in icindeki her bir degeri kullanicinin girebilmesi icin for dongusu kullaniyoruz
            for(int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* ilk once ilk sayiyi belirliyoruz, sonrasinda ikinci bir for dongusu ile bir sayi daha belirliyoruz.
             * eger ki ilk sayi ikinci sayidan kucuk ise ilk sayimizi baslangic isimli degiskene atiyoruz. sonrasinda ilk sayimizi kendisinden
             * buyuk olan sayiya esitliyoruz. daha dogrusu ikinci sayiya. sonra ise ikinci sayiya baslangic degiskenine atamis oldugumuz sayiyi
             * atiyoruz. bu islemler dongu icinde oldugu icin sirasi ile devam edecektir.
             * 
             * En kolay yontemi ile anlatacak olursam, mesela, 5 4 6 2 1 sayilarimiz mevcut. Program ilk once 5'e bakiyor. sonra ise 4'e. Bubble sorting
             * teknigi sadece 2 sayiyi ayni ayna karsilastigi icin durum boyle oluyor. eger ki ilk sayi ikinji sayidan buyuk ise ilk sayiyi one atiyor.
             * mesela 5 4'ten buyuk. simdi 4 5 6 2 1 olarak yazilacak. sonra 5 ile 6'yi karsilastiriyor. bunlar dogru. sonra 6 ile 2'yi. program 4 5 2 6 1
             * olacaktir. sonra 6 ile 1'i. 4 5 2 1 6 olacaktir. az onceki islemi tekrar yapiyor ve en sonunda sira ile dizilinceye kadar devam ediyor.
             */


            for(int j = 0; j < sayilar.Length; j++)
            {
                for(int a = 0; a < sayilar.Length; a++)
                {
                    if(sayilar[j] < sayilar[a])
                    {
                        baslangic = sayilar[j];
                        sayilar[j] = sayilar[a];
                        sayilar[a] = baslangic;
                    }
                }
            }


            // bu alanda ise artik sira ile dizilen sayilari sadece ekrana yazdirmak kaliyor. bunu da for dongusu ile yapiyoruz

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0} ", sayilar[i]);
            }
        }
    }
}
