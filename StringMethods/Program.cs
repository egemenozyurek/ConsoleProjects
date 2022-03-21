using System;

namespace StringMethods {
    class Program {
        static void Main (string[] args) {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length; - string degiskeninin uzunluğunu verir
            Console.WriteLine (degisken.Length);

            //ToUpper, ToLower - degiskeni büyük harf- kücük harf yapar
            Console.WriteLine (degisken.ToUpper ());
            Console.WriteLine (degisken.ToLower ());

            //Concat - degiskene ekstra bir ifade eklememize yarar. birden fazla parametre alabilir
            Console.WriteLine (String.Concat (degisken, " Merhaba"));

            //Compare, CompareTo: iki değişkeni karşılaştırmamıza yarar. iki degisken arasında 1 ve 0 döndürür.
            Console.WriteLine (degisken.CompareTo (degisken)); //0,1,-1
            Console.WriteLine (String.Compare (degisken, degisken2, true));
            Console.WriteLine (String.Compare (degisken, degisken2, false));

            //Contains; iki degisken içerisinde aynı ifadelerin olup olmadığını kontrol eder, sonucu true ya da false döndürür.
            Console.WriteLine (degisken.Contains (degisken2));
            Console.WriteLine (degisken.EndsWith ("Hoşgeldiniz!"));
            Console.WriteLine (degisken.StartsWith ("Merhaba"));

            //IndexOf: verilen ifadenin sahip olduğu ilk index numarasını verir. (C) bulamazsa -1 döner
            Console.WriteLine (degisken.IndexOf ("CSharp"));
            Console.WriteLine (degisken.IndexOf ("Egemen"));
            Console.WriteLine (degisken.LastIndexOf ("i"));

            //Insert
            Console.WriteLine (degisken.Insert (0, "Merhaba"));

            //PadLeft,PadRight
            Console.WriteLine (degisken + degisken2.PadLeft (30, '*'));
            Console.WriteLine (degisken.PadRight (50, '-') + degisken2);

            //Remove
            Console.WriteLine (degisken.Remove (10));
            Console.WriteLine (degisken.Remove (5, 3));
            Console.WriteLine (degisken.Remove (0, 1));

            //Replace
            Console.WriteLine (degisken.Replace ("C#", "C Sharp"));
            Console.WriteLine (degisken.Replace (" ", "*"));

            //Split
            Console.WriteLine (degisken.Split (" ") [1]);

            //SubString
            Console.WriteLine (degisken.Substring (4));

        }
    }
}