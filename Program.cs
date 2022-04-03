using System;

namespace Encapsulation_and_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* ÖĞRENCİ 1 BİLGİLERİ ***************");
            Ogrenci öğrenci1= new Ogrenci();
            öğrenci1.Isim = "Batuhan";
            öğrenci1.Soyİsim = "ALTINEL";
            öğrenci1.OgrenciNo= 248;
            öğrenci1.Sinif=7;
            öğrenci1.OgrenciBilgileriniGetir();
            öğrenci1.SinifAtlat();
            öğrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("************* ÖĞRENCİ 2 BİLGİLERİ ***************");
            Ogrenci öğrenci2 = new Ogrenci("Ali","Erguvan",1453,1);
            öğrenci2.OgrenciBilgileriniGetir();
            öğrenci2.SinifDusur();
            öğrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyİsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            get => isim; 
            set => isim = value; 
            }
        public string Soyİsim { 
            get {return soyİsim;} 
            set {soyİsim = value;} 
            }

        public int OgrenciNo { 
            get => ogrenciNo;
            set => ogrenciNo = value; 
            }
        public int Sinif { 
            get => sinif; 
            set 
            {
                if (value <1)
                {
                    Console.WriteLine("Sınıf en az 1 olmalıdır!");
                    sinif=1;
                }else
                 sinif = value;
            } 
            }

        public Ogrenci(string isim, string soyİsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyİsim = soyİsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("*********** Öğrenci Bilgileri ***********");
            Console.WriteLine("Öğrencinin Adı       :{0}",this.Isim);
            Console.WriteLine("Öğrencinin Soyadı    :{0}",this.Soyİsim);
            Console.WriteLine("Öğrencinin Numarası  :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı    :{0}",this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif ++;
        }
        public void SinifDusur(){
            this.Sinif--;
        }
    }
}
