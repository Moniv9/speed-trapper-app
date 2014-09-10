using System;

namespace car_app
{
  interface ICar
  {
    /// <summary>
    /// Get list of all cars from resource file
    /// </summary>
    /// <returns>json output</returns>
    string GetList();
  }
}
