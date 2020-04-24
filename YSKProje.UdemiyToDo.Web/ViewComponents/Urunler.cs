using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.UdemiyToDo.Web.Models;

namespace YSKProje.UdemiyToDo.Web.ViewComponents
{
    public class Urunler: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new List<MusteriViewModel>() {
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
             new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"}


            });
        }
    }
}
