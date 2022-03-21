using System;

namespace Q1 {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Pozitif bir sayi giriniz");
            int n = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("{0} adet sayi giriniz", n);
            for (int i = 0; i < n; i++) {
                Console.WriteLine ("{0} adet sayi giriniz", i + 1);
                int sayi = Convert.ToInt32 (Console.ReadLine ());
                if (sayi % 2 == 0) {
                    Console.WriteLine ("Çift " + sayi);
                }
            }
        }
    }
}