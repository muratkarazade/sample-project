using CarModel.Car.CarSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car.CarTypes
{
    public class ClasicCar : ICar, IClasic
    {
        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CarType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CarColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public FuelType FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ModelYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Antique { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }



}
