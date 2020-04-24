using CYSKProje.UdemiyToDo.Entities.interfaces;
using System.Collections.Generic;

namespace CYSKProje.UdemiyToDo.Entities.Concrate
{
    public   class Kullanici: ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

      public List<Calisma> Calismaalar { get; set; }

    }
}
