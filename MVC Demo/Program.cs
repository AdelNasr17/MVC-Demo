using Microsoft.AspNetCore.Routing.Constraints;
using System.Buffers.Text;

namespace MVC_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            // app.MapGet("/", () => "Hello World!");

            //BaseURL / Movies / GetMovie / 10
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute
                    (
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"//:regex(^\\d{{2}}$)?}"//{name:alpha}" // Id is optional
                                                               //defaults : new { action = "Index", controller = "Movies" },
                                                               //constraints : new{Id=new IntRouteConstraint() } 
                                                               //constraints: new { Id = @"\d{2}" }
                    );

            });




            //app.MapGet("/X{name}", async context =>
            //{
            //    //var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            //});

            app.Run();
          


           
        }
    }
    }
