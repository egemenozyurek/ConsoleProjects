using System;

namespace ClassNotion {
    class Program {
        static void Main (string[] args) {
            // class SinifAdi {
            //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi ([Parametreler]) {
            //         Metot Gövdesi
            //     }
            // }

            //Erişim Belirleyiciler
            // * public
            // * private
            // * Internal
            // * protected

            Calisan calisan1 = new Calisan ();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "Insan Kaynakları";

            calisan1.CalisanBilgileri ();

            Console.WriteLine ("***********************************");

            Calisan calisan2 = new Calisan ();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 23445689;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri ();
        }
    }

    class Calisan {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri () {
            Console.WriteLine ("Çalışanın Adı:{0}", Ad);
            Console.WriteLine ("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine ("Çalışanın Numarası:{0}", No);
            Console.WriteLine ("Çalışanın Departmanı:{0}", Departman);

        }
    }
}