namespace YemekMenusu
{
    class Salata : Yiyecek
    {
        public int Kalori { get; set; }

        public Salata(string adi, double fiyat, double kdv, int kalori)
            : base(adi, "Salata", fiyat, kdv)
        {
            Kalori = kalori;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {Kalori,5} kcal";
        }
    }
}
