using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController
    {
        [Route("sayhello")]
        public string Method1()
        {
            return "Hello from method1";
        }
    }
}
