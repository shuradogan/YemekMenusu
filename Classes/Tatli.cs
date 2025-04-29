namespace YemekMenusu
{
    class Tatli : Yiyecek
    {
        public int Kalori { get; set; }

        public Tatli(string adi, double fiyat, double kdv, int kalori)
            : base(adi, "Tatlı", fiyat, kdv)
        {
            Kalori = kalori;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {Kalori,5} kcal";
        }
    }
}
