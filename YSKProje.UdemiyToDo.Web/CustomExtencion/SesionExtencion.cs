using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.UdemiyToDo.Web.CustomExtencion
{
    public  static class SesionExtencion
    {
        public static void SetObject(this ISession session, string key, object deger) 
        {
            string gelendata = JsonConvert.SerializeObject(deger);
            session.SetString(key, gelendata);
        }



        public static T GetObject<T>(this ISession session, string key) where T : class, new()
        {
            string gelenData = session.GetString(key);
            if (gelenData !=null)
            {
               return JsonConvert.DeserializeObject<T>(gelenData);
            }
            else
            {
                return null;
            }
            
        }

    }
}
