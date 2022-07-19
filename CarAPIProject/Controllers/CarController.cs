using CarModel.Car.CarDB;
using CarModel.Car.CarTypes;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<List<AllSkillCar>> GetCarAsync()
        {
            return Cache.CarList.ToList();
             
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<AllSkillCar> GetCarByCapacityAsync(int capacity)
        {
            var item =  Cache.CarList.Select(x=>x.Capacity >= 4).FirstOrDefault();
            if (item == null) return null;
            return Cache.CarList.FirstOrDefault();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<List<AllSkillCar?>> GetByCarModelYearAsync(int modelYear)
        {
          
            return  Cache.CarList.Where(x=>x.ModelYear==modelYear).ToList();
            
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<AllSkillCar> GetByCarPriceAsync(double Price)
        {
            List<double> priceList =  Cache.CarList.Select(x=>x.Price).ToList();
            return Cache.CarList.FirstOrDefault();
           
        }

        [HttpPost]
        [Route("[action]")]
        public async  Task<List<AllSkillCar>> AddCarAsync(AllSkillCar allSkillCar)
        {
           Cache.CarList.Add(allSkillCar);
           return Cache.CarList;

        }
        [HttpPut]
        [Route("[action]")]
        public async Task<bool> EditCarAsync([FromBody] AllSkillCar car)
        {
            var ok = false;
            if (car == null) { return false; }
            try
            {
                Cache.CarList = Cache.CarList.Where(x => x.Id != car.Id).Concat(new AllSkillCar[] { car }).ToList();
                await new JsonOperations().WriteJsonAsync(Cache.CarList);
                ok = true;
            }

            catch (Exception e)
            {

                throw new Exception("not found", e);
            }
            return ok;

        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<bool> RemoveCarAsync(int id)
        {
            
            var ok = false;
            var car = Cache.CarList.FirstOrDefault(x => x.Id == id);
            if (car == null)  throw new Exception("Not found" );
            Cache.CarList.Remove(car);
            ok = true;
            return ok;
        }
        [HttpDelete] 
        [Route("[action]")]
        public async Task<bool> RemoveAllCarAsync()
        {
            Cache.CarList.Clear();
            return true;
        }




    }
}
