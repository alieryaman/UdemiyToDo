using CYSKProje.UdemiyToDo.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.UdemiyToDo.Business.interfaces;
using YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Repostories;

namespace YSKProje.UdemiyToDo.Business.Concrate
{
   public class CalismaManager: ICalismaService
    {

        private readonly EfCalismaRepostory _efCalismaRepostory;
        public CalismaManager(EfCalismaRepostory efCalismaRepostory)
        {
            efCalismaRepostory = efCalismaRepostory;
        }
        public List<Calisma> Getirhepsi()
        {
            return _efCalismaRepostory.Getirhepsi();
        }

        public Calisma GetirIdile(int id)
        {
            return _efCalismaRepostory.GetirIdile(id);
        }

        public void Guncelle(Calisma tablo)
        {
            _efCalismaRepostory.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            _efCalismaRepostory.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            _efCalismaRepostory.Sil(tablo);
        }
    }
}
