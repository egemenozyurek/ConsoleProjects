using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("Mantıksal Operatörler");
            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great !");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine !");
            }

            Console.WriteLine("İlişkisel Operatörler");
            //Ilişkisel Operatorler
            // <, > <=, >=, == !=

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            Console.WriteLine("Aritmetik Operatörler");
            // Aritmetik Operatorler
            // +, -, *, /, %, ++, --
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi1 % sayi2;
            Console.WriteLine(sonuc);
        }
    }
}
