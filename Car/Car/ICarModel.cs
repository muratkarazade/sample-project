using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car
{
    public enum CarType { Clasic, Sedan, HatchBag, SUV, Roader, Sport }
    public enum CarColor { White, Black, Red, Yellow, Gray, Blue, Pink, Purple, Brown, Green, Orange }
    public enum FuelType { Gas, Diesel, Electric, Hybrid }
    public interface ICar
    {
        public string? Name { get; set; }
        public CarType Type { get; set; }
        public CarColor Color { get; set; }
        public FuelType FuelType { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public DateTime ModelYear { get; set; }

    }
}
