using Microsoft.AspNetCore.Routing.Constraints;
using System.Buffers.Text;

namespace MVC_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Eng / Aliaa
            //var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllers();
            //var app = builder.Build();
            //app.UseRouting();

            //app.MapGet("/", () => "Hello World!");

            ////BaseURL / Movies / GetMovie / 10
            //app.MapControllerRoute
            //    (
            //    name: "Default",
            //    pattern: "{controller=Movies}/{action=Index}/{Id?}"//:regex(^\\d{{2}}$)?}"//{name:alpha}" // Id is optional
            //                                                       //defaults : new { action = "Index", controller = "Movies" },
            //                                                       //constraints : new{Id=new IntRouteConstraint() } 
            //                                                       //constraints: new { Id = @"\d{2}" }
            //    );






            ////app.MapGet("/X{name}", async context =>
            ////{
            ////    //var Name = context.GetRouteValue("name");
            ////   await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            ////});

            //app.Run(); 
            #endregion
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You Are at Home Page");
                });



                endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("You Are at Products Page");
                });


                endpoints.MapGet("/Products/{id?}", async context =>
                {
                    var IdData= context.Request.RouteValues["id"];
                    if(IdData != null)
                    {
                        int id = Convert.ToInt32(IdData);
                        await context.Response.WriteAsync($"You Request  Product With Id => {id}");

                    }
                    else
                        await context.Response.WriteAsync("You Are at Products Page");



                });


            });

            app.Run(async (httpContext) =>
            {
                await httpContext.Response.WriteAsync("Your Response Page Not Found");

            });

            app.Run();
        }
    }
}
