using CarModel.Car.CarTypes;
using Microsoft.AspNetCore.Mvc;

namespace CarAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<List<AllSkillCar>> GetAllListAsync()
        {
            
            return Cache.CarList;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<AllSkillCar> GetByCapacityAsync(int capacity)
        {
            var item =  Cache.CarList.Select(x=>x.Capacity >= 4).FirstOrDefault();
            if (item == null) return null;
            return Cache.CarList.FirstOrDefault();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<List<AllSkillCar?>> GetOldModel(int modelYear)
        {
            return  Cache.CarList.Where(x=>x.ModelYear==modelYear).ToList();
            
        }

        [HttpPost]
        [Route("[action]")]
        public async  Task<List<AllSkillCar>> Post(AllSkillCar allSkillCar)
        {
           Cache.CarList.Add(allSkillCar);
           return Cache.CarList;

        }



    }
}
