using CarModel.Car.CarDB;
using System.Text.Json;

namespace CarProjectConsole
{
    class Program
    {
       
        public  static void Main()
        {

            JsonOperations jsonOp = new JsonOperations();
            jsonOp.WriteJsonAsync();
            jsonOp.ReadJsonAsync();
           

           

        }


    }
}