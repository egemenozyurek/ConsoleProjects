using System;

namespace Q2 {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Pozitif iki sayı giriniz ");
            int n = Convert.ToInt32 (Console.ReadLine ());
            int m = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("{0} adet sayi giriniz", n);
            for (int i = 0; i < n; i++) {
                Console.WriteLine ("{0}. Sayıyı Giriniz", i + 1);
                int sayi = Convert.ToInt32 (Console.ReadLine ());
                if ((sayi == m) || (sayi % m == 0)) {
                    Console.WriteLine ("Tam bölünüyor " + sayi);
                }
            }
        }
    }
}