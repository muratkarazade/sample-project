using CarModel.Car.CarDB;
using CarModel.Car.CarTypes;
using System.Collections.Generic;
using System.Text.Json;

namespace CarProjectConsole
{
    class Program
    {
       
        public async static Task Main()
        {

            //JsonOperations jsonOp = new JsonOperations();
            //jsonOp.WriteJsonAsync();
            //jsonOp.ReadJsonAsync();

            await RunAsync();
           
            Console.ReadLine();
        }

        static async Task RunAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7242/");
                    HttpResponseMessage response = await client.GetAsync("api/Car/GetCar");
                    response.EnsureSuccessStatusCode();
                    var list = await response.Content.ReadAsAsync<List<AllSkillCar>>();
                    

                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}