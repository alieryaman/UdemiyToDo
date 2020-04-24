using CYSKProje.UdemiyToDo.Entities.interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CYSKProje.UdemiyToDo.Entities.Concrate
{
    public class Calisma:ITablo
    {



       
        public int Id { get; set; }
      
        public string Ad { get; set; }
     
        public string Aciklama { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }
   
        public int KullaniciId { get; set; }
        public bool Durum { get; set; }
        public Kullanici Kullanici { get; set; }




    }
}
