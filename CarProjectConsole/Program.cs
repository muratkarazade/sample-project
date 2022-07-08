using System.Text.Json;

namespace CarProjectConsole
{
    class Program
    {
        public static void Main()
        {



        }

        public object? allCarList;

        public  void JsonFileWrite()
        {
            var url = @"C:\Users\Murat\Desktop\CarList.txt";
            string jsonString = JsonSerializer.Serialize(allCarList);
            File.WriteAllText(url, jsonString);
        }

    }
}