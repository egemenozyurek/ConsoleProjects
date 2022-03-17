using System;

namespace Arrays {
    class Program {
        static void Main (string[] args) {
            //Dizi Tanımlama
            string[] colors = new string[5];

            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            colors[0] = "Blue";
            Console.WriteLine (animals[0]);
            dizi[3] = 10;

            Console.WriteLine (animals[1]);
            Console.WriteLine (colors[0]);
            Console.WriteLine (dizi[3]);

            //Döngülerle dizi kullanımı

            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write ("Lütfen dizinin eleman sayısını giriniz");
            int diziUzunlugu = int.Parse (Console.ReadLine ());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++) {
                Console.Write ("Lütfen {0}. sayısı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse (Console.ReadLine ());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi) {
                toplam += sayi;
            }
            Console.WriteLine ("Ortalama :" + toplam / diziUzunlugu);

        }
    }
}