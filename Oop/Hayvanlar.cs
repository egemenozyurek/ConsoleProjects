using System;

namespace Oop {
    public class Hayvanlar : Canlilar {
        protected void Adaptasyon () {
            Console.WriteLine ("Hayvanlar adaptasyon kurabilir");
        }
        public void Avlanmak () {
            Console.WriteLine ("Hayvanlar avlanır");
        }
    }

    public class Sürüngenler : Hayvanlar {
        public Sürüngenler () {
            base.Adaptasyon ();
            base.Beslenme ();
            base.Bosaltim ();
            base.Solunum ();
        }
        public void Sürünmek () {
            Console.WriteLine ("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar {
        public Kuslar () {
            base.Adaptasyon ();
            base.Beslenme ();
            base.Bosaltim ();
            base.Solunum ();
        }
        public void Ucmak () {
            Console.WriteLine ("Hayat kısa kuşlar uçuyor.");
        }
    }
}