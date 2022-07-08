using CarModel.Car.CarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarModel.Car.CarDB
{
    public class JsonOperations
    {
        private object? allCarList;

        public void JsonFileWrite()
        {
            var url = @"C:\Users\Murat\Desktop\CarList.txt";
            string jsonString = JsonSerializer.Serialize(allCarList);
            File.WriteAllText(url, jsonString);
        }
        
    }
}
