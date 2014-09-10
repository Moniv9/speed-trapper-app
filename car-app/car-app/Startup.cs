using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(car_app.Startup))]
namespace car_app
{
  public class Startup
  {
    public void Configuration(IAppBuilder app) {
      app.MapSignalR("/signalr", new Microsoft.AspNet.SignalR.HubConfiguration());     
    }


  }
}