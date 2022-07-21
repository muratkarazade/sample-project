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
            //await CarListAsync();
            //await CapacityAsync();
            //await ModelYearAsync();
            //await PriceAsync();
            //await AddCarAsync();
            //await Test2Async(1);
            await Test3Async(1, 4);

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
                    if (response.IsSuccessStatusCode)
                    {
                    var list = await response.Content.ReadAsAsync<bool>();
                    }
                    else {
                        var str = await response.Content.ReadAsStringAsync();
                        response.EnsureSuccessStatusCode(); 
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("not found", ex);
            }
        }

        static async Task Test2Async(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7242/api/Car/");
                    var updateCar = new AllSkillCar() { Id = id, ModelYear = 2022, Name="Bentley" , Type=CarModel.Car.CarType.Clasic, Antique=true, Color=CarModel.Car.CarColor.White,Price=1111};
                    var response = await client.PostAsJsonAsync("test2", updateCar);
                    if (response.IsSuccessStatusCode)
                    {
                        var list = await response.Content.ReadAsAsync<object>();
                    }
                    else
                    {
                        var str = await response.Content.ReadAsStringAsync();
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

         static async Task Test3Async(int id , int capacity)
        {
            try
            {
                using (var client = new HttpClient())
                { 
                   
                    client.BaseAddress = new Uri("https://localhost:7242/api/Car/test3");
                    var newCar = new AllSkillCar() { Id = id, ModelYear = 2022, Name = "Airbus", Capacity=capacity, Type = CarModel.Car.CarType.Clasic, Antique = true, Color = CarModel.Car.CarColor.White, Price = 1111 };
                    var response = await client.PostAsJsonAsync("", newCar);
                    if (response.IsSuccessStatusCode) { var list = await response.Content.ReadAsAsync<object>(); } else { var str = await response.Content.ReadAsStringAsync(); }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}