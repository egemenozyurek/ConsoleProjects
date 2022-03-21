using System;

namespace Q4 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bir cümle giriniz .");
            string cumle = Console.ReadLine ();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" +
                "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler = cumle.Split (' ');
            Console.WriteLine ("Kelime Sayısı :" + kelimeler.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++) {
                //karakter katarkter kontrol ediyoruz.
                if (liste.Contains (cumle[i])) {
                    sayac++;
                }
            }
            Console.WriteLine ("toplam {0} tane  harf vardır.", sayac);
        }
    }
}