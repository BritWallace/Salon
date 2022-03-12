using Microsoft.AspNetCore.Mvc;

namespace Salons.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}