using System;
using System.Windows.Forms;

namespace YemekMenusu
{
    public partial class Form1 : Form
    {
        private Menu m = new Menu();  

        private Yiyecek s;
        private Menu menu = new Menu();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbYiyecekTuru.Items.Add("Meyve");
            cmbYiyecekTuru.Items.Add("Salata");
            cmbYiyecekTuru.Items.Add("Tatlı");
            cmbYiyecekTuru.Items.Add("İçecek");

            cmbYiyecekTuru.SelectedIndex = 0;

            
{
    cmbYiyecekTuru.Items.Clear();  

    cmbYiyecekTuru.Items.Add("Meyve");
    cmbYiyecekTuru.Items.Add("Salata");
    cmbYiyecekTuru.Items.Add("Tatlı");
    cmbYiyecekTuru.Items.Add("İçecek");

    cmbYiyecekTuru.SelectedIndex = 0; 
}

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            string cins = txtCins.Text;
            double fiyat, kdv;
            int kalori;

            // Girişlerin geçerli olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(adi) || string.IsNullOrWhiteSpace(cins) ||
                !double.TryParse(txtFiyat.Text, out fiyat) ||
                !double.TryParse(txtKdv.Text, out kdv) ||
                !int.TryParse(txtKalori.Text, out kalori))
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // **Negatif değerleri kontrol et**
            if (fiyat < 0 || kdv < 0 || kalori < 0)
            {
                MessageBox.Show("Fiyat, KDV ve Kalori değerleri negatif olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kdv /= 100; // KDV'yi yüzde olarak al

            string secilenTur = cmbYiyecekTuru.SelectedItem.ToString();

            switch (secilenTur)
            {
                case "Meyve":
                    s = new Meyve(adi, fiyat, kdv, kalori);
                    break;
                case "Salata":
                    s = new Salata(adi, fiyat, kdv, kalori);
                    break;
                case "Tatlı":
                    s = new Tatli(adi, fiyat, kdv, kalori);
                    break;
                case "İçecek":
                    s = new Icecek(adi, fiyat, kdv, kalori);
                    break;
            }

            if (s != null)
            {
                m.Ekle(s);
                lstMenu.Items.Add($"{secilenTur} - {adi} - {cins} - {fiyat:C} - {kdv * 100}% - {kalori} kcal");
            }

            // Kutucukları temizle
            txtAdi.Clear();
            txtFiyat.Clear();
            txtKdv.Clear();
            txtKalori.Clear();
            txtCins.Clear();

            cmbYiyecekTuru.SelectedIndex = 0;
        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = lstMenu.SelectedIndex;
            if (seciliIndex != -1)
            {
                m.Sil(seciliIndex);  
                lstMenu.Items.RemoveAt(seciliIndex);  
            }
        }


        private void cmbYiyecekTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            double toplamFiyat = 0;
            int toplamKalori = 0;

            foreach (var item in m.MenuYazdir())
            {
                toplamFiyat += item.Fiyat;
                if (item is Meyve meyve)
                    toplamKalori += meyve.Kalori;
                else if (item is Salata salata)
                    toplamKalori += salata.Kalori;
                else if (item is Tatli tatli)
                    toplamKalori += tatli.Kalori;
                else if (item is Icecek icecek)
                    toplamKalori += icecek.Kalori;
            }

            if (toplamFiyat <= 500 && toplamKalori <= 2000)
            {
                MessageBox.Show($"MENÜ ONAYLANDI! \nToplam Fiyat: {toplamFiyat:C} \nToplam Kalori: {toplamKalori} kcal",
                                "Menü Kabul Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($" MENÜ BELİRTİLEN SINIRLARI AŞIYOR!\n\nFiyat Sınırı = 500 tl     Kalori Sınırı = 2000 kcal\n\nToplam Fiyat: {toplamFiyat:C}      Toplam Kalori: {toplamKalori} kcal ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
