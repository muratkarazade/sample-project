﻿using CarModel.Car.CarSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car.CarTypes
{
    internal class RoadCar : ICar, IRoad
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public CarType Type { get; set; }
        public CarColor Color { get; set; }
        public FuelType FuelType { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int ModelYear { get; set; }
        public int Machine { get; set; }


        public RoadCar()
        {
            this.Type = CarType.Roader;
        }
    }
}
