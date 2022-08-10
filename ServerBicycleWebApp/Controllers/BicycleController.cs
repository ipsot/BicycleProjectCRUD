using ServerBicycleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerBicycleWebApp.Controllers
{
    public class BicycleController : ApiController
    {
        [HttpPost]
        public List<Bicycle> GetAllBicycle()
        {
            return BicycleParameters.GetAllBicycle();
        }
        [HttpPost]
        public Bicycle GetBicycleById([FromBody]int id)
        {
            return BicycleParameters.GetBicycleById(id);
        }
        [HttpPost]
        public bool DeleteBicycleById([FromBody] int id)
        {
            return BicycleParameters.DeleteBicycleById(id);
        }
        [HttpPost]
        public bool  UpadeteBycicle([FromBody]Bicycle newBicycle)
        {
            return BicycleParameters.UpadeteBycicle(newBicycle);
        }
        [HttpPost]
        public void AddNewBicycle([FromBody]Bicycle bicycle)
        {
            BicycleParameters.AddNewBicycle(bicycle);
        }

    }
}
