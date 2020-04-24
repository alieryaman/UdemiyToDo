using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSKProje.UdemiyToDo.Web.Models;

namespace YSKProje.UdemiyToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Isim = "ViewBag beşir";
            TempData["Isim"]= " TempData beşir";
            ViewData["Isim"] = "ViewDatabeşir";
            return View(new List<MusteriViewModel>() { 
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
             new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"},
            new MusteriViewModel(){Ad="Beşir"}


            });
        }
        
     
        public IActionResult kayitOl()
        {

            return View();
        }

        [HttpPost]
        public IActionResult kayitOl(KullaniciKayitViewModel model)
        {
            ModelState.AddModelError(nameof(KullaniciKayitViewModel.Ad),"Adalanı boş geçileömz");
            ModelState.AddModelError("","Modelle ilhili hata");

            return View("kayitOl",model);
        }



    }
}