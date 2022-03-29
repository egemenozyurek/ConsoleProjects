using System;

namespace AbstractClasses {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("**************INTERFACE***************");

            Focus focus = new Focus ();
            Console.WriteLine (focus.HangiMarkaninAraci ().ToString ());
            Console.WriteLine (focus.KacTekerlektenOlusur ());
            Console.WriteLine (focus.StandartRengiNe ().ToString ());

            Console.WriteLine ("*****************************");

            Civic civic = new Civic ();
            Console.WriteLine (civic.HangiMarkaninAraci ().ToString ());
            Console.WriteLine (civic.KacTekerlektenOlusur ());
            Console.WriteLine (civic.StandartRengiNe ());

            Console.WriteLine ("**************ABSTRACT***************");

            NewFocus focus1 = new NewFocus ();
            Console.WriteLine (focus1.HangiMarkaninAraci ().ToString ());
            Console.WriteLine (focus1.KacTekerlektenOlusur ());
            Console.WriteLine (focus1.StandartRengiNe ().ToString ());

            Console.WriteLine ("*****************************");

            NewCivic civic1 = new NewCivic ();
            Console.WriteLine (civic1.HangiMarkaninAraci ().ToString ());
            Console.WriteLine (civic1.KacTekerlektenOlusur ());
            Console.WriteLine (civic1.StandartRengiNe ().ToString ());
        }
    }
}