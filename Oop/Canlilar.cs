using System;

namespace Oop {
    public class Canlilar {
        protected void Beslenme () {
            Console.WriteLine ("Canlılar beslenir.");
        }
        protected void Solunum () {
            Console.WriteLine ("Canlılar solunum yapar");
        }
        protected void Bosaltim () {
            Console.WriteLine ("Canlılar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki () {
            Console.WriteLine ("Canlılara Tepki");
        }
    }
}