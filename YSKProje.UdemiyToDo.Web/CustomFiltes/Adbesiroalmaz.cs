using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.UdemiyToDo.Web.Models;

namespace YSKProje.UdemiyToDo.Web.CustomFiltes
{
    public class Adbesiroalmaz:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
          var geleDictonary=    context.ActionArguments.Where(I => I.Key == "model").FirstOrDefault();
            var model = (KullaniciKayitViewModel)geleDictonary.Value;
            if (model.Ad.ToLower()=="beşir")
            {
                context.Result = new RedirectResult(@"Home\Error");
            }

        }
    }
}
