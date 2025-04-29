using YemekMenusu;

namespace YemekMenusu
{
    class Meyve : Yiyecek
{
    public int Kalori { get; set; }

    public Meyve(string adi, double fiyat, double kdv, int kalori)
        : base(adi, "Meyve", fiyat, kdv)
    {
        Kalori = kalori;
    }

    public override string Yazdir()
    {
        return base.Yazdir() + $" {Kalori,5} kcal";
    }
}
}
