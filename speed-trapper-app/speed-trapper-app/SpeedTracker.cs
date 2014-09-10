using Microsoft.AspNet.SignalR;


namespace speed_trapper_app
{
  public class TrackerHub : Hub
  {
    private static int speedLimit = 0;

    /// <summary>
    /// Send & recieve car speed details
    /// </summary>
    /// <param name="car"></param>
    /// <param name="speed"></param>
    public void Send(string car, int speed) {
      if (speed >= speedLimit) {
        Clients.Caller.bustmessage("You are busted");
        Clients.All.overspeed(car, speed);
      }
      else
        Clients.All.validspeed(car, speed);

    }


    public void SetLimit(int speed) {
      speedLimit = speed;
    }



  }
}