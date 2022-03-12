using Microsoft.AspNetCore.Mvc;

namespace HairSalons.Controllers
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