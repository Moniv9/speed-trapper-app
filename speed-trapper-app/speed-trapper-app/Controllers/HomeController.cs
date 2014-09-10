using System.Web.Mvc;

namespace speed_trapper_app.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index() {
      return View();
    }


    public ActionResult SpeedTrap() {
      return View();
    }


  }
}
