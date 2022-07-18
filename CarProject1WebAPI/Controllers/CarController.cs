using CarModel.Car;
using CarModel.Car.CarDB;
using CarModel.DBOperations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarProject1WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CarController (CarDbContext context) { _context = context; }

        [HttpGet]
        public List<CarDB> GetCars()
        {
            var carList = _context.Cars.OrderBy(x => x).ToList(CarDB);
            return carList;
        }

    }
}
