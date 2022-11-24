using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            // return new ContentResult()
            // {
            //     Content = "Hello from Index",
            //     ContentType = "text/plain"
            // };

            // return Content("Hello from Index", "text/plain");

            return Content("<h1>Welcome</h1> <h2>Hello from Index</h2>", "text/html");
        }

        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "James",
                LastName = "Smith",
                Age = 25
            };

            // return new JsonResult(person);
            return Json(person);
            // return "{ \"key\": \"value\" }";
        }

        // [Route("file-download")]
        // public VirtualFileResult FileDownload()
        // {
        //     // return new VirtualFileResult("/sample.pdf", "application/pdf");
        //     return File("/sample.pdf", "application/pdf");
        // }

        // [Route("file-download2")]
        // public VirtualFileResult FileDownload2()
        // {
        //     return new VirtualFileResult(@"~/sample.pdf", "application/pdf");
        // }

        // [Route("file-download3")]
        // public PhysicalFileResult FileDownload3()
        // {
        //     return PhysicalFile(@"C:\ControllersExample\ControllersExample\wwwroot\Sample.pdf", "application/pdf");
        // }

        // [Route("file-download4")]
        // public FileContentResult FileDownload4()
        // {
        //     byte[] bytes = System.IO.File.ReadAllBytes(@"C:\ControllersExample\ControllersExample\wwwroot\Sample.pdf");
        //     return new FileContentResult(bytes, "application/pdf");
        // }

        // [Route("file-download5")]
        // public FileContentResult FileDownoad5()
        // {
        //     byte[] bytes = System.IO.File.ReadAllBytes(@"C:\ControllersExample\ControllersExample\wwwroot\Sample.pdf");
        //     return File(bytes, "application/pdf");
        // }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from Contact";
        }
    }
}
