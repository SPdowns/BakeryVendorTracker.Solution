using Microsoft.AspNetCore.Mvc;

namespace BakeryVendorTracker.Controllers
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