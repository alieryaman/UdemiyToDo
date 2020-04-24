using CYSKProje.UdemiyToDo.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Context;
using YSKProje.UdemiyToDo.DataAccsess.interfaces;

namespace YSKProje.UdemiyToDo.DataAccsess.Concrate.EntityFramworkCore.Repostories
{
    public class EfGenerikRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public List<Tablo> Getirhepsi()
        {
            using var context = new TodoContext();
            return context.Set<Tablo>().ToList();
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new TodoContext();
            return context.Set<Tablo>().Find(id);
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();

        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

    }
}
