using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.UdemiyToDo.Web.Models;

namespace YSKProje.UdemiyToDo.Web.ViewComponents
{
    public class Yeniiewcomponent: ViewComponent
    {




        public IViewComponentResult Invoke()
        {
            return View("Yeni",new List<MusteriViewModel>() {
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
