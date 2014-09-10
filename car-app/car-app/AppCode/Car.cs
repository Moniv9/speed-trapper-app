using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace car_app
{
  public class Car : ICar
  {
    public string GetList() {
      string[] carList = File.ReadAllLines(GetFile());
      return JsonConvert.SerializeObject(carList);
    }


    private string GetFile() {
      return HttpContext.Current.Server.MapPath("~/resources/car-names.txt");
    }


  }
}