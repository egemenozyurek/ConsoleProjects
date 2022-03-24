using System;
using System.Collections;
using System.Collections.Generic;

namespace Q1 {
    class Program {
        static void Main (string[] args) {
            Manager manager = new Manager ();

            ArrayList list = new ArrayList ();
            ArrayList prime = new ArrayList ();
            ArrayList notPrime = new ArrayList ();

            Console.WriteLine ("20 adet pozitif sayı giriniz:");
            try {
                for (int i = 1; i < 21; i++) {
                    Console.Write ("{0}.pozitif sayı :", i);
                    int number = int.Parse (Console.ReadLine ());
                    if (number < 0) {
                        Console.WriteLine ("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    list.Add (number);
                }
            } catch (Exception) {

                Console.WriteLine ("Lütfen pozitif bir sayı girniz");
            }
            Console.WriteLine ("----------------------------------------------------------");

            foreach (int item in list) {
                if (item == 1) {
                    notPrime.Add (item);
                } else if (item == 2) {
                    prime.Add (item);
                } else {
                    int primeNumber = 0;
                    for (int i = 2; i < item; i++) {
                        if (item % i == 0) {
                            primeNumber++;
                        }
                    }
                    if (primeNumber == 0) {
                        prime.Add (item);
                    } else {
                        notPrime.Add (item);
                    }
                }
            }
            Console.WriteLine ("Asal olan sayıların büyükten küçüğe sıralanışı :");
            manager.PrimeProperties (prime);
            Console.WriteLine ("Asal olanların eleman sayısı : " + prime.Count);
            manager.Average (prime);
            Console.WriteLine ("Asal olmayanların büyükten küçüğe sıralanışı :");
            manager.PrimeProperties (notPrime);
            Console.WriteLine ("Asal olmayanların eleman  sayısı : " + notPrime.Count);
            manager.Average (notPrime);
        }
    }

    public class Manager {
        public ArrayList PrimeProperties (ArrayList arr) {
            arr.Sort ();
            arr.Reverse ();
            foreach (var item in arr) {
                Console.WriteLine (item + " ");
            }
            return arr;
        }

        public ArrayList Average (ArrayList arr) {
            int total = 0;
            foreach (int item in arr) {
                total += item;
            }
            decimal avg = total / arr.Count;
            Console.WriteLine ("Average:" + avg);
            return arr;
        }
    }
}