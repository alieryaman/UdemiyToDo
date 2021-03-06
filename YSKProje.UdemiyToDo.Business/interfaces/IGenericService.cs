﻿using CYSKProje.UdemiyToDo.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.UdemiyToDo.Business.interfaces
{
   public interface IGenericService<Tablo> where Tablo : class,ITablo, new()
    {

        void Kaydet(Tablo tablo);

        void Sil(Tablo tablo);

        void Guncelle(Tablo tablo);
        Tablo GetirIdile(int id);

        List<Tablo> Getirhepsi();

    }
    
}
