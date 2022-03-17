using System;

namespace ArrayMethods {
    class Program {
        static void Main (string[] args) {

            // sort metotu
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine ("******Sırasız Liste******");

            foreach (int sayi in sayiDizisi) {
                Console.WriteLine (sayi);
            }

            Console.WriteLine ("******Sıralı Liste******");
            Array.Sort (sayiDizisi);

            foreach (int sayi in sayiDizisi) {
                Console.WriteLine (sayi);
            }

            //Clear metotu
            Console.WriteLine ("******Array Clear******");

            //sayiDizisi içerisindeki elemanları kullanarak 2. indexten itibaren 2 elemanı sıfırla
            Array.Clear (sayiDizisi, 2, 2);

            foreach (int sayi in sayiDizisi) {
                Console.WriteLine (sayi);
            }

            //reverse metotu
            Console.WriteLine ("******Array Reverse******");
            Array.Reverse (sayiDizisi);
            foreach (int sayi in sayiDizisi) {
                Console.WriteLine (sayi);
            }

            //IndexOf metotu
            Console.WriteLine ("******Array IndexOf******");
            Console.WriteLine (Array.IndexOf (sayiDizisi, 23));

            //resize metotu
            Console.WriteLine ("******Array Resize******");
            Array.Resize<int> (ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (int sayi in sayiDizisi) {
                Console.WriteLine (sayi);
            }
        }
    }
}