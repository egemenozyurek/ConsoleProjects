using System;

namespace EncapsulationAndProperty {
    class Program {
        static void Main (string[] args) {
            Ogrenci ogrenci = new Ogrenci ();
            ogrenci.Isim = "Ayşe";
            ogrenci.SoyIsim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir ();

            ogrenci.SinifAtlat ();
            ogrenci.OgrenciBilgileriniGetir ();

            Ogrenci ogrenci1 = new Ogrenci ("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur ();
            ogrenci1.SinifDusur ();
            ogrenci1.OgrenciBilgileriniGetir ();

        }
    }

    class Ogrenci {
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim {
            get { return isim; }
            set { isim = value; }
        }

        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif {
            get => sinif;
            set {

                if (value < 1) {
                    Console.WriteLine ("Sınıf en az 1 olabilir");
                    sinif = 1;
                } else {
                    sinif = value;
                }

            }
        }

        public Ogrenci (string ısim, string soyIsim, int ogrenciNo, int sinif) {
            Isim = ısim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci () {

        }

        public void OgrenciBilgileriniGetir () {
            Console.WriteLine ("********* Öğrenci Bilgileri *********");
            Console.WriteLine ("Öğrenci Adı      :{0}", this.Isim);
            Console.WriteLine ("Öğrenci Soyadı   :{0}", this.SoyIsim);
            Console.WriteLine ("Öğrenci No       :{0}", this.OgrenciNo);
            Console.WriteLine ("Öğrenci Sınıfı   :{0}", this.Sinif);
        }

        public void SinifAtlat () {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur () {
            this.Sinif = this.Sinif - 1;
        }
    }
}