using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YSKProje.UdemiyToDo.Web.CustomExtencion;
using YSKProje.UdemiyToDo.Web.CustomFiltes;
using YSKProje.UdemiyToDo.Web.Models;

namespace YSKProje.UdemiyToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            setCookie();

            ViewBag.Cookie = GetCookie();

            SetSession();
            ViewBag.seion = GetSession();





            ViewBag.Isim = "ViewBag beşir";
            TempData["Isim"] = " TempData beşir";
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
        [Adbesiroalmaz]
        [HttpPost]
        public IActionResult kayitOl(KullaniciKayitViewModel model)
        {
            ModelState.AddModelError(nameof(KullaniciKayitViewModel.Ad), "Adalanı boş geçileömz");
            ModelState.AddModelError("", "Modelle ilhili hata");

            return View("kayitOl", model);
        }
       
        
        public void setCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "beşircookie", new
                Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(20),
                HttpOnly = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict


            });


        } 

        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }


        public void SetSession()
        {
            //HttpContext.Session.SetString("kisi", "ismal");
            HttpContext.Session.SetObject("Kisi", new KullaniciKayitViewModel() { Ad = "beşir", Soyad = "aydemir" });
        }
        public KullaniciKayitViewModel GetSession()
        {
           return HttpContext.Session.GetObject<KullaniciKayitViewModel>("Kisi");
        }

        public IActionResult PagerErorr(int code)
        {
            ViewBag.hatacodu = code;
            return View(); ;
        }

        public IActionResult Hata()
        {
            throw new Exception("Hata oluştu");
        }

        public IActionResult Erorr()
        {
            var exceptionHandlerPathFeature =  HttpContext.Features.Get<IExceptionHandlerPathFeature>();
             ViewBag.path=  exceptionHandlerPathFeature.Path;
             ViewBag.Message = exceptionHandlerPathFeature.Error.Message;

            return View();
        }

    }



}
