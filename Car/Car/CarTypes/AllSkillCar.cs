﻿using CarModel.Car.CarSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car.CarTypes
{
    public class AllSkillCar : ICar,IClasic,IHatchBag,IRoad,ISedan,ISport,ISUV
    {
        public string? Name { get; set; }
        public CarType Type { get; set; }
        public CarColor Color { get; set; }
        public FuelType FuelType { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int ModelYear { get; set; }
        public bool Antique { get; set; }
        public bool Sunroof { get; set; }
        public int Machine { get; set; }
        public string Tire { get; set; }
        public string TurboName { get; set; }
        public int Headlamps { get; set; }
    }
}