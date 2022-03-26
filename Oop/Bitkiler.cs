using System;

namespace Oop {
    public class Bitkiler : Canlilar {
        protected void Fotosentez () {
            Console.WriteLine ("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler {
        public TohumluBitkiler () {
            base.Fotosentez ();
            base.Beslenme ();
            base.Bosaltim ();
            base.Solunum ();
        }
        public void TohumlaCogalma () {
            Console.WriteLine ("Tohumla bitkiler tohumla çoğalırlar.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler {

        public TohumsuzBitkiler () {
            base.Fotosentez ();
            base.Beslenme ();
            base.Bosaltim ();
            base.Solunum ();
        }
        public void SporlaCogalma () {
            Console.WriteLine ("Tohumsuz bitkiler sporla çoğalırlar");
        }
    }
}