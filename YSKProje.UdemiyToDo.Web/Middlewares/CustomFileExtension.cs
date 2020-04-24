using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.UdemiyToDo.Web.Middlewares
{
    public static class CustomFileExtension
    {
        public static void useRouting(this IApplicationBuilder app)
        {


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                );
            });



            app.UseEndpoints(endpoints =>
            {
               
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}"



                );
            });
        }

    }
}
