using System;

namespace Q2 {
    class Program {
        static void Main (string[] args) {
            // Soru-2 Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük üç tanesini bulan     
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
            // toplamlarını console yazdıran programı yazınız(Array sınıfını kullanınız)

            int[] sayilar = new int[20];
            int[] minSayilar = new int[3];
            int[] maxSayilar = new int[3];
            for (int i = 0; i < 20; i++) {
                Console.Write ("{0}.pozitif sayı :", i + 1);
                sayilar[i] = int.Parse (Console.ReadLine ());
            }

            Array.Sort (sayilar);
            double minSayac = 0;

            for (int i = 0; i < 3; i++) {
                minSayilar[i] = sayilar[i];
            }
            Console.WriteLine ("Dizinin en küçük elemanları:");
            foreach (var item in minSayilar) {
                Console.WriteLine (item);
                minSayac += item;
            }

            Array.Reverse (sayilar);
            double maxSayac = 0;

            for (int i = 0; i < 3; i++) {
                maxSayilar[i] = sayilar[i];
            }
            Console.WriteLine ("Dizinin en büyük elemanları:");
            foreach (var item in maxSayilar) {
                Console.WriteLine (item);
                maxSayac += item;
            }
            double minAvr = minSayac / 3;
            double maxAvr = maxSayac / 3;

            Console.WriteLine ("Küçük dizinin ortalaması :" + minAvr);
            Console.WriteLine ("Büyük dizinin ortalaması :" + maxAvr);
            Console.WriteLine ("Büyük ve Küçük Dizinin Ortalama Toplamları :" + (minAvr + maxAvr));

            int number;
            number = int.Parse ("5");
            if (number > 0)
                Console.Write ("positive");
        }
    }
}