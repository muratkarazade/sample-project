using CarModel.Car.CarTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace CarModel.Car.CarDB
{
    public class JsonOperations
    {
       public async Task  WriteJsonAsync()
        {
            await File.WriteAllTextAsync($"{AppDomain.CurrentDomain.BaseDirectory}\\CarList.json", JsonConvert.SerializeObject(CarDB.list), new UTF8Encoding(false));
        }
        public async Task<List<AllSkillCar>> ReadJsonAsync()
        {
            var json = await File.ReadAllTextAsync($"{AppDomain.CurrentDomain.BaseDirectory}\\CarList.json", new UTF8Encoding(false));
            return JsonConvert.DeserializeObject<List<AllSkillCar>>(json);
        }
    }
}
