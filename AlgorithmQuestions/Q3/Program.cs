using System;
using System.Collections.Generic;
using System.Text;

namespace Q3 {
    class Program {
        static void Main (string[] args) {
            List<string> words = new List<string> ();
            Console.Write ("Pozitif bir sayı giriniz ");
            int n = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("{0} adet kelime giriniz", n);
            for (int i = 0; i < n; i++) {
                Console.WriteLine ("{0}. Kelimeyi Giriniz", i + 1);
                string word = Console.ReadLine ();
                words.Add (word);
            }

            int last = words.Count - 1;
            Console.WriteLine ("---Sondan Başa Doğru Kelimeler---");
            for (int i = last; i >= 0; --i) {
                Console.WriteLine (words[i]);
            }
        }
    }
}