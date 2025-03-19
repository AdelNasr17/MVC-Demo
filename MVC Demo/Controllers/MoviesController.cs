using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class MoviesController : Controller
    {
        // BaseURL/Movies/Index

        public string Index()
        {
            return "Hello from Index";
        }

        // BaseURL/Movies/GetMovie?id=10&name=film
        #region Example 01 :
        //[HttpPost]
        //public ContentResult GetMovie(int? id ,string name)
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content= $"Movies With Name = {name} And Id = {id}";
        //    //result.ContentType = "text/html";
        //    return Content($"Movies With Name = {name} And Id = {id}","text/html");
        //} 
        #endregion

        [HttpGet]
        public IActionResult GetMovie(int? id, string name)
        {
            // Id = 0 _> Bad Request
            // Id <10 -> Not Found 
            // Id >= 10 -> Return Movies

            if (id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content($"Movies With Name = {name} And Id = {id}","text/html");
        }

        public IActionResult TestRedirctaction()
        {
            return Redirect("https://depi.gov.eg/content/home");
        }

        [NonAction]
        public void DeleteMovie()
        {

        }
    }
}
