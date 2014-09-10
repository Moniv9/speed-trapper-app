using System.Web.Mvc;

namespace car_app.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index() {
      return View();
    }


    public ActionResult Car() {
      ICar car = new Car();
      ViewBag.carList = car.GetList();

      return View();
    }

  }
}
