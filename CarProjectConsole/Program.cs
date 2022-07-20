using CarModel.Car.CarTypes;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace CarProjectConsole
{
    class Program
    {

        public async static Task Main()
        {
           // await CarListAsync();
            //await CapacityAsync();
            //await ModelYearAsync();
            //await PriceAsync();

            await AddCarAsync();
            Console.ReadLine();
        }
        static async Task CarListAsync()
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

        static async Task CapacityAsync()
        {
            try
            {
               using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7242/");
                    HttpResponseMessage response = await  client.GetAsync("api/Car/GetCarByCapacity");
                    response.EnsureSuccessStatusCode();
                    var list = await response.Content.ReadAsAsync<AllSkillCar>();
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception("not found", ex); 
            }
        }

        static async Task ModelYearAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7242/");
                    HttpResponseMessage response = await client.GetAsync("api/Car/GetByCarModelYear");
                    response.EnsureSuccessStatusCode();
                    var list = await response.Content.ReadAsAsync<List<AllSkillCar>>();
                }

            }
            catch (Exception ex)
            {

                throw new Exception("not found", ex);
            }
        }

        static async Task PriceAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7242/");
                    HttpResponseMessage response = await client.GetAsync("api/Car/GetByCarPrice");
                    response.EnsureSuccessStatusCode();
                    var list = await response.Content.ReadAsAsync<AllSkillCar>();
                }

            }
            catch (Exception ex)
            {

                throw new Exception("not found", ex);
            }
        }

       
        static async Task AddCarAsync()
        {
            try
            {
                using (var client = new HttpClient())
                { 
                    client.BaseAddress = new Uri("https://localhost:7242/api/Car/");
                    var c = new AllSkillCar() { Id = 62, ModelYear = 2001, Capacity = 4, Color = CarModel.Car.CarColor.White,  Name = "Ford" };
                   // client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsJsonAsync("addcar", c);
                    var str = await response.Content.ReadAsStringAsync();
                    var list = await response.Content.ReadAsAsync<object>();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("not found", ex);
            }
        }


    }
}