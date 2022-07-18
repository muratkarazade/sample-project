using CarModel.Car.CarSkills;

namespace CarModel.Car.CarTypes
{
    public class ClasicCar : ICar, IClasic
    {
       
        public string? Name { get; set; }
        public CarType Type { get; set; }
        public CarColor Color { get; set; }
        public FuelType FuelType { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int ModelYear { get; set; }
        public bool Antique { get; set; }



        public ClasicCar()
        {
            this.Type = CarType.Clasic;
        }
    }



}
