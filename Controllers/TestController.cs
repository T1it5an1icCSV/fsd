using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            return View();
        }

        // Другие действия (Details, Create, Edit, Delete) остаются без изменений
    }
}
