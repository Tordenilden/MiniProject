using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    [Route("api/[controller]")] // soon
    [ApiController] // soon
    public class CarController : ControllerBase
    {


        // definer en metode som returnere en int og bagefter en der returnere string
        //[HttpGet]
        //public int getAll()
        //{
        //    return 100;
        //}
        [HttpGet] // Dataannotation / Attribute (class, som sætter et regelsæt op)
        public List<Car> getAll()
        {
            //indexer
            List<Car> listCars = new List<Car>
            {
                new Car(){carId=1,model="127",brand="fiat",color="sort"},
                new Car(){carId=1,model="127",brand="fiat",color="sort"},
                new Car{carId=1,model="127",brand="fiat",color="sort"},
            };
            return listCars;
        }
    }
}
