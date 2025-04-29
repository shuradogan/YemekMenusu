using System.Collections.Generic;

namespace YemekMenusu
{
    class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();

        public void Ekle(Yiyecek item)
        {
            liste.Add(item);
        }

        public void Sil(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }

        public List<Yiyecek> MenuYazdir()
        {
            return liste;
        }
    }
}
