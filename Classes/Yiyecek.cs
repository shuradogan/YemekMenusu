using System;
using YemekMenusu;

namespace YemekMenusu
{
    class Yiyecek
    {
        public string Adi { get; set; }
        public string Cins { get; set; }
        public double Fiyat { get; set; }
        public double KdvOrani { get; set; }

        public Yiyecek()
        {
            Adi = "";
            Cins = "";
            Fiyat = 0;
            KdvOrani = 0;
        }

        public Yiyecek(string adi, string cins, double fiyat, double kdv)
        {
            Adi = adi;
            Cins = cins;
            Fiyat = fiyat;
            KdvOrani = kdv;
        }

        public virtual string Yazdir()
        {
            return string.Format("{0,-10} {1,-10} {2,10:C} {3,5}%", Adi, Cins, Fiyat, KdvOrani * 100);
        }
    }
}
