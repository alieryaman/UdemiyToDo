using CYSKProje.UdemiyToDo.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.UdemiyToDo.Business.interfaces;
using YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Repostories;

namespace YSKProje.UdemiyToDo.Business.Concrate
{
    public class KullaniciManager : IKullaniciService
    {

        private readonly EfKullaniciRepostory _efKullaniciRepostory;
        public KullaniciManager(EfKullaniciRepostory efKullaniciRepostory)
        {
            _efKullaniciRepostory = efKullaniciRepostory;
        }
        public List<Kullanici> Getirhepsi()
        {
            return _efKullaniciRepostory.Getirhepsi();
        }

        public Kullanici GetirIdile(int id)
        {
           return  _efKullaniciRepostory.GetirIdile(id);
        }

        public void Guncelle(Kullanici tablo)
        {
            _efKullaniciRepostory.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            _efKullaniciRepostory.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            _efKullaniciRepostory.Sil(tablo);
        }
    }
}
