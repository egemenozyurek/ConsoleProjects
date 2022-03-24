using System;
using System.Collections.Generic;

namespace Q3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bir cümle giriniz:");
            string input = Console.ReadLine ();
            char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u' };

            List<char> harfler = new List<char> ();

            foreach (var item in input) {
                foreach (var sabit in sesliHarfler) {
                    if (item == sabit)
                        harfler.Add (item);
                }
            }

            Console.WriteLine ("Cümle içerisindeki sesli harfler :");
            foreach (var item in harfler) {
                Console.Write (item + " ");
            }
        }
    }
}