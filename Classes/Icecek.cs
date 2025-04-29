namespace YemekMenusu
{
    class Icecek : Yiyecek
    {
        public int Kalori { get; set; }

        public Icecek(string adi, double fiyat, double kdv, int kalori)
            : base(adi, "İçecek", fiyat, kdv)
        {
            Kalori = kalori;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {Kalori,5} kcal";
        }
    }
}
