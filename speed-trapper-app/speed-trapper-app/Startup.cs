using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(speed_trapper_app.Startup))]
namespace speed_trapper_app
{
  public class Startup
  {
    public void Configuration(IAppBuilder app) {
      
      app.Map("/signalr", map => {
        
        /* Allow cross origin request */
        map.UseCors(CorsOptions.AllowAll);

        var hubConfiguration = new HubConfiguration {
          EnableJSONP = true
        };

        map.RunSignalR(hubConfiguration);
      });
    }
  }
}